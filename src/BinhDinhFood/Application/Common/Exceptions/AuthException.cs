using BinhDinhFood.Domain.Constants;

namespace BinhDinhFood.Application.Common.Exceptions;

public static class AuthException
{
    public static UserFriendlyException ThrowTokenNotExist()
        => throw new UserFriendlyException(ErrorCode.NotFound, AuthErrorMessage.TokenNotExistMessage, AuthErrorMessage.TokenNotExistMessage);

    public static UserFriendlyException ThrowTokenNotActive()
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.TokenNotActiveMessage, AuthErrorMessage.TokenNotActiveMessage);

    public static UserFriendlyException ThrowAccountDoesNotExist()
        => throw new UserFriendlyException(ErrorCode.NotFound, AuthErrorMessage.AccountDoesNotExistMessage, AuthErrorMessage.AccountDoesNotExistMessage);

    public static UserFriendlyException ThrowLoginUnsuccessful()
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.LoginUnsuccessfulMessage, AuthErrorMessage.LoginUnsuccessfulMessage);

    public static UserFriendlyException ThrowUsernameAvailable()
        => throw new UserFriendlyException(ErrorCode.NotFound, AuthErrorMessage.UsernameAvailableMessage, AuthErrorMessage.UsernameAvailableMessage);

    public static UserFriendlyException ThrowEmailAvailable()
        => throw new UserFriendlyException(ErrorCode.NotFound, AuthErrorMessage.EmailAvailableMessage, AuthErrorMessage.EmailAvailableMessage);

    public static UserFriendlyException ThrowRegisterUnsuccessful(string errors)
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.RegisterUnsuccessfulMessage, errors);

    public static UserFriendlyException ThrowUserNotExist()
        => throw new UserFriendlyException(ErrorCode.NotFound, AuthErrorMessage.UserNotExistMessage, AuthErrorMessage.UserNotExistMessage);

    public static UserFriendlyException ThrowUpdateUnsuccessful(string errors)
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.UpdateUnsuccessfulMessage, errors);

    public static UserFriendlyException ThrowDeleteUnsuccessful()
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.DeleteUnsuccessfulMessage, AuthErrorMessage.DeleteUnsuccessfulMessage);

    public static UserFriendlyException ThrowInvalidFacebookToken()
        => throw new UserFriendlyException(ErrorCode.NotFound, AuthErrorMessage.InvalidFacebookTokenMessage, AuthErrorMessage.InvalidFacebookTokenMessage);

    public static UserFriendlyException ThrowErrorLinkedFacebook()
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.ErrorLinkedFacebookMessage, AuthErrorMessage.ErrorLinkedFacebookMessage);

    public static UserFriendlyException ThrowRegisterFacebookUnsuccessful(string errors)
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.RegisterFacebookUnsuccessfulMessage, errors);

    public static UserFriendlyException ThrowErrorLinkedGoogle()
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.ErrorLinkedGoogleMessage, AuthErrorMessage.ErrorLinkedGoogleMessage);

    public static UserFriendlyException ThrowRegisterGoogleUnsuccessful(string errors)
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.RegisterGoogleUnsuccessfulMessage, errors);

    public static UserFriendlyException ThrowInvalidAppleToken()
        => throw new UserFriendlyException(ErrorCode.NotFound, AuthErrorMessage.InvalidAppleTokenMessage, AuthErrorMessage.InvalidAppleTokenMessage);

    public static UserFriendlyException ThrowEmailRequired()
        => throw new UserFriendlyException(ErrorCode.NotFound, AuthErrorMessage.EmailRequiredMessage, AuthErrorMessage.EmailRequiredMessage);

    public static UserFriendlyException ThrowErrorLinkedApple()
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.ErrorLinkedAppleMessage, AuthErrorMessage.ErrorLinkedAppleMessage);

    public static UserFriendlyException ThrowRegisterAppleUnsuccessful(string errors)
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.RegisterAppleUnsuccessfulMessage, errors);

    public static UserFriendlyException ThrowUserNotFound()
        => throw new UserFriendlyException(ErrorCode.NotFound, AuthErrorMessage.UserNotFoundMessage, AuthErrorMessage.UserNotFoundMessage);

    public static UserFriendlyException ThrowGenerateTheNewOTP()
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.GenerateTheNewOTPMessage, AuthErrorMessage.GenerateTheNewOTPMessage);

    public static UserFriendlyException ThrowOTPWrong()
        => throw new UserFriendlyException(ErrorCode.BadRequest, AuthErrorMessage.OTPWrongMessage, AuthErrorMessage.OTPWrongMessage);

}
