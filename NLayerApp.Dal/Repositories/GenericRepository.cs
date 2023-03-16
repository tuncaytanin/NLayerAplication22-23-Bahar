using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Dal.Repositories
{
    public class GenericRepository<IEntity> : IGenericRepository<IEntity> where IEntity : class
    {
        // protected
        // private
        // public
        protected readonly AppDbContext _context;

        protected readonly DbSet<IEntity> _dbSet;

        public GenericRepository()
        {
            _context = new AppDbContext();
            _dbSet = _context.Set<IEntity>();
        }

        public async Task AddAsync(IEntity entity)
        {
          await _dbSet.AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<IEntity, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public void Delete(IEntity Entity)
        {
           _dbSet.Remove(Entity);
        }

        public async Task DeleteAsync(int id)
        {
           var entite = await _dbSet.FindAsync(id);
            _dbSet.Remove(entite);  
        }

        public IQueryable<IEntity> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<List<IEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id); ;
        }

        public void Update(IEntity entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<IEntity> Where(Expression<Func<IEntity, bool>> expression)
        {
           return _dbSet.AsNoTracking().Where(expression);
        }
    }
}
