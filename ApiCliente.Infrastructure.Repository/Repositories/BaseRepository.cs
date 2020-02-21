using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApiCliente.Domain.Core.Interfaces;
using ApiCliente.Domain.Core.Interfaces.Repositories;
using ApiCliente.Infrastruture.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiCliente.Infrastructure.Repository.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SqlContext _context;
        public BaseRepository(SqlContext Context)
        {

            _context = Context;
        }
        public void Add(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual void Update(TEntity obj)
        {

            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual void Remove(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual void Dispose()
        {
            _context.Dispose();
        }

    }
}
