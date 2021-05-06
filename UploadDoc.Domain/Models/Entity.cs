using System;
using System.Collections.Generic;
using System.Text;

namespace UploadDoc.Domain.Models
{
    /// <summary>
    /// Classe com campos em comuns entre as classes
    /// </summary>
    public class Entity
    {
        public int Id { get; set; }
        public DateTime DateCreaded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}
