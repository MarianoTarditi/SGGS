using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateEntityAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetAllList();
        Task<T> GetEntityByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
    }
}
