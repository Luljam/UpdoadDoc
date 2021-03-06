using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Domain.Entities;

namespace UploadDoc.Domain.Interfaces
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        IEnumerable<Pessoa> GetAll();
        Pessoa Find(int pessoaId);
        Pessoa FindByProntuario(int prontuario);
    }
}