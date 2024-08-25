using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;

// DbContext referenced in this class

namespace TelemetryPortal_MVC.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly TechtrendsContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepo(TechtrendsContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllGenericAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetGenericByIdAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);

            if (entity == null)
            {
                throw new InvalidOperationException($"{typeof(T).Name} with ID: {id} was not found.");
            }
            return entity;
        }

        public async Task AddGenericAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateGenericAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGenericAsync(Guid id)
        {
            var entity = await GetGenericByIdAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> GenericExistsAsync(Guid id)
        {
            return await _dbSet.FindAsync(id) != null;
        }
    }
}
