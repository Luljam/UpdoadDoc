using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using UploadDoc.Domain.Models;

namespace UploadDoc.Domain.Entities
{
    public class Pessoa : Entity
    {
        public int Prontuario { get; set; }
        public string Nome { get; set; }
    }
}
