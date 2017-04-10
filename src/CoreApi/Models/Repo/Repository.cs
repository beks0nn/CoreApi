using CoreApi.Models.DomainModel.Interface;
using CoreApi.Models.Repo.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CoreApi.Models.Repo
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IPersistentEntity
    {
        protected readonly DbContext Context;
        protected readonly DbSet<TEntity> _entities;    

        public Repository(DbContext context)
        {
            Context = context;
            _entities = Context.Set<TEntity>();
        }


        public void Add(TEntity entity)
        {
            _entities.Add(entity);
            Context.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public TEntity Get(Guid id)
        {
            return _entities.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public void Remove(Guid id)
        {
            var entity = _entities.FirstOrDefault(t => t.Id == id);
            if (entity == null)
                return;
            _entities.Remove(entity);
            Context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _entities.Update(entity);
            Context.SaveChanges();
        }
    }
}