using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Application.ViewModels;
using UploadDoc.Domain.Entities;

namespace UploadDoc.Application.AutoMapper
{
    /// <summary>
    /// Classe que mapeia as propriedades a Entidade para Viewmodel e de ViewModel para Entiade
    /// </summary>
    public class AutoMapperSetup : Profile
    {
        // Necessário instalar vie nuget AutoMapper e AutoMapper DependencyInjection
        
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<UserViewModel, User>();

            #endregion

            #region DomainToViewModel

            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<User, UserViewModel>();
            #endregion
        }
    }
}
