using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UploadDoc.Application.AutoMapper;
using UploadDoc.Application.Services;
using UploadDoc.Application.ViewModels;
using UploadDoc.Data.Context;
using UploadDoc.Data.Repositories;
using UploadDoc.Domain.Entities;
using UploadDoc.Domain.Interfaces;
using Xunit;

namespace UploadDoc.Application.Tests
{
    public class UserServiceTests
    {
        private UserService userService;
        private readonly Mock<IUserRepository> _userRepoMock = new Mock<IUserRepository>();
        private readonly Mock<IMapper> _mapperMock = new Mock<IMapper>();

        public UserServiceTests()
        {
            userService = new UserService(_userRepoMock.Object, _mapperMock.Object);
        }

        [Fact]
        public void Authentication_EnviandoUmIDValido()
        {
            //envio de Objeto vazio se email ou senha o correto dar exception
            var exception = Assert.Throws<Exception>(() => userService.Authenticate(new UserAuthenticateRequestViewModel()));

            Assert.Equal("Email/Password are required.", exception.Message);
        }

        [Fact]
        public void Delete_EnviandoUmIDNulo()
        {
            //// Crio uma lista de usuários como se fossem do banco de dados
            //List<User> _users = new List<User>();
            //_users.Add(new User { Id = 1, Name = "Luciano Brito", Email = "lucianofdebrito@gmail.com", IsActive=true });

            //// Simulo o metodo de comunicação com banco e uso o meto de pesquisa todos detornando users da lista fake
            //var _userRepository = new Mock<IUserRepository>();
            //_userRepository.Setup(x => x.GetAll()).Returns(_users);

            //// Simulando IMapper
            //var _autoMapperProfile = new AutoMapperSetup();
            //var _configuration = new MapperConfiguration(x => x.AddProfile(_autoMapperProfile));
            //IMapper _mapper = new Mapper(_configuration);

            // Arrange 
            string _userId = null;

            // Act
            var exception = Assert.Throws<Exception>(() => userService.Delete(_userId));

            // Assert
            Assert.Equal("UserID is empty.", exception.Message);
        }

        [Fact]
        public void Delete_QuandousuarioNaoExisteRetornaNotFound()
        {
            // Arrage
            var usuario = new User { Id = 1, Name = "Luciano de Brito", Email = "lucianofdebrito@gmail.com", DateCreaded = DateTime.Now, IsActive = true };

            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase("DefaultContext").Options;
            var contexto = new ApplicationContext(options);

            contexto.Users.Add(usuario);
            contexto.SaveChanges();

            var repo = new UserRepository(contexto);

            // Simulando IMapper
            var _autoMapperProfile = new AutoMapperSetup();
            var _configuration = new MapperConfiguration(x => x.AddProfile(_autoMapperProfile));
            IMapper _mapper = new Mapper(_configuration);

            // Usuário com Id = 2
            string userId = "2";
            var handler = new UserService(repo, _mapper);
            // Act
            var ex = Assert.Throws<Exception>(() => handler.Delete(userId));
            // Assert
            Assert.Equal("User not found", ex.Message);
        }
    }
} 