using System;
using System.Collections.Generic;
using System.Linq;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories.Interfaces;

namespace SimpleChat.DAL.Repositories
{
    public class CredentialsRepository:IRepository<CredentialsEntity>
    {
        private readonly SimpleChatDbContext _dbContext;
        public CredentialsRepository(SimpleChatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<CredentialsEntity> GetAll()
        {
            return _dbContext.Credentials.ToList();
        }

        public CredentialsEntity GetById(Guid id)
        {
            return _dbContext.Credentials.FirstOrDefault(s => s.Id == id);
        }

        public void Remove(Guid id)
        {
            CredentialsEntity entity = _dbContext.Credentials.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                _dbContext.Credentials.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public CredentialsEntity Add(CredentialsEntity entity)
        {
            if (entity != null)
            {
                _dbContext.Credentials.Add(entity);
                _dbContext.SaveChanges();
            }
            return entity;
        }

        public void Update(CredentialsEntity entity)
        {
            if (entity != null)
            {
                _dbContext.Credentials.Update(entity);
                _dbContext.SaveChanges();
            }
        }
    }
}