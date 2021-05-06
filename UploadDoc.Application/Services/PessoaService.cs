using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Application.Interfaces;
using UploadDoc.Application.ViewModels;
using UploadDoc.Domain.Entities;
using UploadDoc.Domain.Interfaces;

namespace UploadDoc.Application.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository pessoaRepository;
        public PessoaService(IPessoaRepository pessoaRepository)
        {
            this.pessoaRepository = pessoaRepository;
        }
        public List<PessoaViewModel> Get()
        {
            // Crio uma lista para converter Pessoa em PessoaViewModel para passar para o controller
            List<PessoaViewModel> _pessoaViewModels = new List<PessoaViewModel>();
            IEnumerable<Pessoa> _pessoa = pessoaRepository.GetAll();

            foreach (var item in _pessoa)
            {
                _pessoaViewModels.Add(new PessoaViewModel {
                    Id = item.Id,
                    Prontuario = item.Prontuario,
                    Nome = item.Nome
                });
            }

            return _pessoaViewModels;
        }

        public bool Post(PessoaViewModel pessoaViewModel)
        {
            Pessoa _pessoa = new Pessoa
            {
                Id = pessoaViewModel.Id,
                Prontuario = pessoaViewModel.Prontuario,
                Nome = pessoaViewModel.Nome,
            };

            this.pessoaRepository.Create(_pessoa);

            return true;
        }
    }
}
