using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Domain.Entities;

namespace UploadDoc.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        IEnumerable<Pessoa> GetAll();
    }
}
