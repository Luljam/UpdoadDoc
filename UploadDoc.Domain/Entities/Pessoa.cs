using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UploadDoc.Domain.Entities
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }
        public int Prontuario { get; set; }
        public string Nome { get; set; }
    }
}
