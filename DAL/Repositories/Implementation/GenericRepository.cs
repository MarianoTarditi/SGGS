using DAL.Repositories.Interfaces;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly dbContext _context;

        public GenericRepository(dbContext context)
        {
            _context = context;
        }

        public async Task<T> CreateEntityAsync(T entidad)
        {
            try
            {
                await _context.Set<T>().AddAsync(entidad);
                return entidad;
            }
            catch
            {
                throw;
            }
        }

        public void Update(T entidad)
        {
            try
            {
                _context.Set<T>().Update(entidad);
            }
            catch
            {
                throw;
            }
        }

        public void Delete(T entidad)
        {
            try
            {
                _context.Set<T>().Remove(entidad);
            }
            catch
            {
                throw;
            }
        }

        public IQueryable<T> GetAllList()
        {
            try
            {
               return  _context.Set<T>().AsQueryable();
                 
            }
            catch
            {
                throw;
            }
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public async Task<T> GetEntityByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
