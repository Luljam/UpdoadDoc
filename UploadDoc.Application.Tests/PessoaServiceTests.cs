using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Application.AutoMapper;
using UploadDoc.Application.Interfaces;
using UploadDoc.Application.Services;
using UploadDoc.Application.ViewModels;
using UploadDoc.Data.Context;
using UploadDoc.Data.Repositories;
using UploadDoc.Domain.Entities;
using UploadDoc.Domain.Interfaces;
using Xunit;

namespace UploadDoc.Application.Tests
{
    public class PessoaServiceTests
    {
        private readonly IPessoaService pessoaService;
        private readonly Mock<IPessoaRepository> _pessoaRepoMock = new Mock<IPessoaRepository>();
        private readonly Mock<IMapper> _mapperMock = new Mock<IMapper>();

        public PessoaServiceTests()
        {
            pessoaService = new PessoaService(_pessoaRepoMock.Object, _mapperMock.Object);
        }

        [Fact]
        public void Pessoa_GetByIdInexistenteRetornaNotFound()
        {
            var exception = Assert.Throws<Exception>(() => pessoaService.GetById(1));
            Assert.Equal("Not found", exception.Message);
        }

        [Fact]
        public void Pessoa_GetByIdExiste()
        {
            // Arrange
            Pessoa pessoa = new Pessoa { Id = 1, Nome = "Luciano Brito", Prontuario = 5234646, DateCreaded=DateTime.Now, IsActive=true };

            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase("DefaultContext").Options;
            var contexto = new ApplicationContext(options);

            contexto.Pessoas.Add(pessoa);
            contexto.SaveChanges();

            var _autoMapperProfile = new AutoMapperSetup();
            var _configuration = new MapperConfiguration(x => x.AddProfile(_autoMapperProfile));
            IMapper _mapper = new Mapper(_configuration);

            var repo = new PessoaRepository(contexto);
            var handler = new PessoaService(repo, _mapper);

            // Act
            PessoaViewModel result = handler.GetById(1);

            // Assert
            Assert.Equal("Luciano Brito", result.Nome);
        }

    }
}
