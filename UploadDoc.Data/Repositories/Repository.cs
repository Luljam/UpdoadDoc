using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using UploadDoc.Data.Context;
using UploadDoc.Domain.Interfaces;
using UploadDoc.Domain.Models;

namespace UploadDoc.Data.Repositories
{
    /// <summary>
    /// Classe genérica
    /// </summary>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationContext _context;
        protected DbSet<TEntity> DbSet
        {
            get
            {
                return _context.Set<TEntity>();
            }
        }

        public Repository(ApplicationContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where)
        {
            try
            {
                return DbSet.Where(where);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public TEntity Create(TEntity model)
        {
            try
            {
                DbSet.Add(model);
                Save();
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(TEntity model)
        {
            try
            {
                if (model is Entity)
                {
                    // Quando o houver a tentativa de deletar registro do banco, será alterado o status do registro como false
                    (model as Entity).IsActive = false;
                    var _entry = _context.Entry(model);

                    DbSet.Attach(model);

                    _entry.State = EntityState.Modified;
                }
                else
                {
                    var _entry = _context.Entry(model);
                    DbSet.Attach(model);
                    _entry.State = EntityState.Deleted;
                }

                return Save() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Save()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Update(TEntity model)
        {
            try
            {
                var entry = _context.Entry(model);
                DbSet.Attach(model);
                entry.State = EntityState.Modified;
                return Save() > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public void Dispose()
        {
            try
            {
                if (_context != null)
                    _context.Dispose();

                GC.SuppressFinalize(this);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
