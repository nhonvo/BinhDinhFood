using System.Security.Claims;
using BinhDinhFood.Application.Common.Exceptions;
using BinhDinhFood.Application.Common.Interfaces;
using BinhDinhFood.Application.Common.Models.Auth.File;
using BinhDinhFood.Application.Common.Models.Auth.UsersIdentity;
using BinhDinhFood.Domain.Entities.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BinhDinhFood.Application.Services;

public class UserService(
    IFileStorageService storageService,
    UserManager<ApplicationUser> userManager,
    IUnitOfWork unitOfWork) : IUserService
{
    private readonly IFileStorageService _storageService = storageService;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public async Task<List<UserViewModel>> Get(CancellationToken cancellationToken)
    {
        var users = await _userManager.Users
            .Include(u => u.UserRoles)
                .ThenInclude(ur => ur.Role)
            .Include(u => u.Image)
            .ToListAsync(cancellationToken: cancellationToken);

        List<UserViewModel> result = users.Select(x => new UserViewModel
        {
            UserId = x.Id,
            Email = x.Email,
            UserName = x.UserName,
            FullName = x.Name,
            Roles = x.UserRoles.Select(ur => ur.Role.Name).ToList(),
            Avatar = x.Image != null ? x.Image.PathMedia : null
        }).ToList();
        return result;
    }

    public async Task Update(UserUpdateRequest request, CancellationToken cancellationToken)
    {

        var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken: cancellationToken)
            ?? throw AuthException.ThrowUserNotExist();

        user.Email = request.Email ?? user.Email;
        user.Name = request.Name ?? user.Name;

        //Lưu Avatar vào Host
        if (request.MediaFile != null)
        {
            var thumb = await _unitOfWork.MediaRepository.FirstOrDefaultAsync(i => i.Id == user.ImageId);

            //Cập nhật Avatar
            if (thumb.PathMedia != null)
            {
                await _storageService.DeleteFileAsync(new DeleteFileRequest { FileName = thumb.PathMedia });
            }
            var pathMedia = await _storageService.AddFileAsync(request.MediaFile);

            thumb.FileSize = request.MediaFile.Length;
            thumb.PathMedia = pathMedia.Path;

            await _unitOfWork.ExecuteTransactionAsync(() => _unitOfWork.MediaRepository.Update(thumb), cancellationToken);
        }

        var result = await _userManager.UpdateAsync(user);
        if (!result.Succeeded)
        {
            List<IdentityError> errorList = result.Errors.ToList();
            var errors = string.Join(", ", errorList.Select(e => e.Description));
            throw AuthException.ThrowUpdateUnsuccessful(errors);
        }
    }

    public async Task Delete(string userId, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByIdAsync(userId)
            ?? throw AuthException.ThrowAccountDoesNotExist();

        //Xoá Avatar ra khỏi Source
        var avatar = await _unitOfWork.MediaRepository.FirstOrDefaultAsync(x => x.Id == user.ImageId);

        if (avatar != null)
        {
            if (avatar.PathMedia != null)
            {
                await _storageService.DeleteFileAsync(new DeleteFileRequest { FileName = avatar.PathMedia });
            }

            await _unitOfWork.ExecuteTransactionAsync(() => _unitOfWork.MediaRepository.Delete(avatar), cancellationToken);
        }

        var result = await _userManager.DeleteAsync(user);

        if (!result.Succeeded)
        {
            List<IdentityError> errorList = result.Errors.ToList();
            var errors = string.Join(", ", errorList.Select(e => e.Description));
            throw AuthException.ThrowDeleteUnsuccessful();
        }
    }
    // Gán quyền người dùng và cập nhật scope
    public async Task RoleAssign(RoleAssignRequest request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByIdAsync(request.UserId)
            ?? throw AuthException.ThrowAccountDoesNotExist();

        // Handle Role Removal
        var removedRoles = request.Roles.Where(x => !x.Selected).Select(x => x.Name).ToList();
        foreach (var roleName in removedRoles)
        {
            if (await _userManager.IsInRoleAsync(user, roleName))
            {
                await _userManager.RemoveFromRoleAsync(user, roleName);
            }
        }

        // Handle Role Assignment
        var addedRoles = request.Roles.Where(x => x.Selected).Select(x => x.Name).ToList();
        foreach (var roleName in addedRoles)
        {
            if (!await _userManager.IsInRoleAsync(user, roleName))
            {
                await _userManager.AddToRoleAsync(user, roleName);
            }
        }

        // Manage Scope Claims

        // Retrieve the existing scope claim
        var existingClaims = await _userManager.GetClaimsAsync(user);
        var scopeClaim = existingClaims.FirstOrDefault(c => c.Type == "scope");

        // Get scopes from the request
        var newScopes = request.Scopes.Where(x => x.Selected).Select(x => x.Name).ToList();

        if (scopeClaim != null)
        {
            // If there is an existing scope claim, remove it
            await _userManager.RemoveClaimAsync(user, scopeClaim);
        }

        if (newScopes.Any())
        {
            // Add the new scope claim
            var newScopeClaim = new Claim("scope", string.Join(" ", newScopes));
            await _userManager.AddClaimAsync(user, newScopeClaim);
        }
    }
}
