using System;
using System.Linq;
using System.Linq.Expressions;
using Antares.Essentials.Data.Entities;

namespace Antares.Essentials.Data.Repositories
{
    public interface IGenericRepository<TEntity> : IDisposable
        where TEntity : class, IEntity
    {
    }

    public interface IGenericRepository<TEntity, TEntityKey> : IDisposable
    where TEntity : class, IEntity<TEntityKey>
    {
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity GetById(TEntityKey id);
        IQueryable<TEntity> GetAll();

        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntityKey id);

        int SaveChanges();
    }
}
