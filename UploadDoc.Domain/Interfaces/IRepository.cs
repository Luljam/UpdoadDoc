using System;
using System.Collections.Generic;
using System.Text;

namespace UploadDoc.Domain.Interfaces
{
    /// <summary>
    /// Classe genérica
    /// </summary>
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Create(TEntity model);
        bool Update(TEntity model);
        bool Delete(TEntity model);
    }
}
