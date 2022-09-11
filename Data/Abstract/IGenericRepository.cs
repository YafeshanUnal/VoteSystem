using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace VoteSystem.Data.Abstract
{

    public interface IGenericRepository<TEntity> where TEntity : class
    {
        
        void Insert (TEntity entity);

        void Delete(int id);
        void Update(TEntity entity);
        List<TEntity> GetListAll();

        TEntity GetById(int id);
    }
}
