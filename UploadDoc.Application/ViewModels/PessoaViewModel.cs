using System;
using System.Collections.Generic;
using System.Text;

namespace UploadDoc.Application.ViewModels
{
    // Por boas práticas o retorno de dados não deve ser de entidades, pois pode conter uma password, ou objeto que o frontend não vai querer
    // Então cria-se  ViewModels para retornar o que o frontend precisa
    // Criar apenas os campos que ira retornar dados para o frontend
    public class PessoaViewModel
    {
        public int Id { get; set; }
        public int Prontuario { get; set; }
        public string  Nome { get; set; }
    }
}
