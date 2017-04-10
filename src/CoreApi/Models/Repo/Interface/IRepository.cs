using CoreApi.Models.DomainModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CoreApi.Models.Repo.Interface
{
    public interface IRepository<TEntity> where TEntity : class, IPersistentEntity
    {
        TEntity Get(Guid id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void Remove(Guid id);
        void Update(TEntity entity);
    }
}
