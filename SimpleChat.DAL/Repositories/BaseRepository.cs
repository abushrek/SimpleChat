using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories.Interfaces;

namespace SimpleChat.DAL.Repositories
{
    public abstract class BaseRepository<TEntity>:IRepository<TEntity> where TEntity:BaseEntity
    {
        protected DbSet<TEntity> SetOfEntities;
        protected DbContext DbContext;

        protected BaseRepository(DbSet<TEntity> setOfEntities, DbContext dbContext)
        {
            SetOfEntities = setOfEntities;
            DbContext = dbContext;
        }

        public IList<TEntity> GetAll()
        {
            return SetOfEntities.ToList();
        }

        public TEntity GetById(Guid id)
        {
            return SetOfEntities.FirstOrDefault(s => s.Id == id);
        }

        public void Remove(Guid id)
        {
            TEntity entity = SetOfEntities.FirstOrDefault(s => s.Id == id);
            if (entity == null)
                return;
            SetOfEntities.Remove(entity);
            DbContext.SaveChanges();
        }

        public TEntity Add(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            SetOfEntities.Add(entity);
            DbContext.SaveChanges();
            return entity;
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            SetOfEntities.Update(entity);
            DbContext.SaveChanges();
        }
    }
}