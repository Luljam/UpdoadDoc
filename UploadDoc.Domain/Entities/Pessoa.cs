using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using UploadDoc.Domain.Models;

namespace UploadDoc.Domain.Entities
{
    public class Pessoa : Entity
    {
        [Index(IsUnique = true)]
        public int Prontuario { get; set; }
        public string Nome { get; set; }
    }
}
