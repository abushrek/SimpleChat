using System;
using System.Collections.Generic;
using SimpleChat.Entities.Interfaces;

namespace SimpleChat.Dal.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        IList<TEntity> GetAll();
        TEntity GetById(Guid id);
        void Remove(Guid id);
        Guid Insert(TEntity entity);
        Guid? Update(TEntity entity);
    }
}