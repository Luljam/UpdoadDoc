using AutoMapper;
using Moq;
using System;
using System.Threading.Tasks;
using UploadDoc.Application.Services;
using UploadDoc.Application.ViewModels;
using UploadDoc.Domain.Interfaces;
using Xunit;

namespace UploadDoc.Application.Tests
{
    public class UserServiceTests
    {
        private readonly UserService userService;
        private readonly Mock<IUserRepository> _userRepoMock = new Mock<IUserRepository>();
        private readonly Mock<IMapper> _mapperMock = new Mock<IMapper>();

        public UserServiceTests()
        {
            userService = new UserService(_userRepoMock.Object, _mapperMock.Object);
        }

        [Fact]
        public void Authentication_SendingValidId()
        {
            //envio de Objeto vazio se email ou senha o correto dar exception
            var exception = Assert.Throws<Exception>(() => userService.Authenticate(new UserAuthenticateRequestViewModel()));

            Assert.Equal("Email/Password are required.", exception.Message);
        }
    }
} 