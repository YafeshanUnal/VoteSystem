namespace VoteSystem.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using VoteSystem.Data.Database;
    using VoteSystem.Data.Abstract;

    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DatabaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

      
        public void Delete(int id)
        {
           var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }


        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<TEntity> GetListAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Insert(TEntity entity)
        {
           _context.Add(entity);
           _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}

