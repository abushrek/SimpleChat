using System;
using System.Collections.Generic;
using SimpleChat.DAL.Entities.Interfaces;

namespace SimpleChat.DAL.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity: IEntity
    {
        IList<TEntity> GetAll();
        TEntity GetById(Guid id);
        void Remove(Guid id);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
    }
}