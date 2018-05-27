using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AdventureWorks.Core
{
    public interface IRepository<TEntity> 
        where TEntity : class
    {
        IEnumerable<TEntity> Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveAll(IEnumerable<TEntity> entities);

    }
}
