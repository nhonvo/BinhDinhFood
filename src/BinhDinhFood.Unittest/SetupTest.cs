using System.Diagnostics.CodeAnalysis;
using AutoFixture;
using AutoMapper;
using BinhDinhFood.Application;
using BinhDinhFood.Application.Common.Interfaces;
using BinhDinhFood.Application.Common.Mappings;
using BinhDinhFood.Infrastructure.Data;
using BinhDinhFood.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace BinhDinhFood.Unittest;

[ExcludeFromCodeCoverage]
public class SetupTest : IDisposable
{

    protected readonly IMapper _mapperConfig;
    protected readonly Fixture _fixture;
    protected readonly Mock<IUnitOfWork> _unitOfWorkMock;
    protected readonly ApplicationDbContext _dbContext;
    protected readonly Mock<IBookService> _bookServiceMock;
    protected readonly Mock<ICurrentTime> _currentTimeMock;
    protected readonly Mock<IBookRepository> _bookRepositoryMock;

    public SetupTest()
    {
        var mappingConfig = new MapperConfiguration(mc => mc.AddProfile(new MapProfile()));
        _mapperConfig = mappingConfig.CreateMapper();
        _fixture = new Fixture();
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _bookServiceMock = new Mock<IBookService>();
        _currentTimeMock = new Mock<ICurrentTime>();
        _bookRepositoryMock = new Mock<IBookRepository>();

        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;
        _dbContext = new ApplicationDbContext(options);

        _currentTimeMock.Setup(x => x.GetCurrentTime()).Returns(DateTime.UtcNow);
    }
    public void Dispose()
    {
        _dbContext.Dispose();
    }
}
