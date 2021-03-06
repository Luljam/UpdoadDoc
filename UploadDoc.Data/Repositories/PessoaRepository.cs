using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Data.Context;
using UploadDoc.Domain.Entities;
using UploadDoc.Domain.Interfaces;

namespace UploadDoc.Data.Repositories
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return Query(x => x.IsActive);
        }

        public Pessoa Find(int pessoaId)
        {
            return Find(x => x.Id == pessoaId);
        }
        public Pessoa FindByProntuario(int prontuario)
        {
            return Find(x => x.Prontuario == prontuario);
        }
    }
}
