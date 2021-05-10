using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Application.ViewModels;

namespace UploadDoc.Application.Interfaces
{
    public interface IPessoaService
    {
        // Por boas práticas o retorno de dados não deve ser de entidades, pois pode conter uma password, ou objeto que o frontend não vai querer
        // Então cria-se  ViewModels para retornar o que o frontend precisa
        List<PessoaViewModel> Get();
        public bool Post(PessoaViewModel pessoaViewModel);
        PessoaViewModel GetById(int id);
        bool Put(PessoaViewModel pessoaViewModel);
    }
}
