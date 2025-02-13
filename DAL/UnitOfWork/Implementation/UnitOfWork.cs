using DAL.Repositories.Interfaces;
using DAL.UnitOfWork.Interfaces;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

namespace DAL.UnitOfWork.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly dbContext _context;

        public UnitOfWork(dbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task<bool> CommitAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException) 
            {
                return false;
            }
        }
        

        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }

        IGenericRepository<T> IUnitOfWork.GetGenericRepository<T>()
        {
            return new GenericRepository<T>(_context);
        }

        //


        public async Task BeginTransactionAsync()
        {
            await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            await _context.SaveChangesAsync();
            await _context.Database.CommitTransactionAsync();
        }

        public async Task RollbackTransactionAsync()
        {
            await _context.Database.RollbackTransactionAsync();
        }

        public DbContext GetDbContext()
        {
            return _context;
        }
    }
}
