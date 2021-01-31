using System;
using System.Collections.Generic;
using System.Linq;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories.Interfaces;

namespace SimpleChat.DAL.Repositories
{
    public class ChannelUserRepository:IRepository<ChannelUserEntity>
    {
        private readonly SimpleChatDbContext _dbContext;
        public ChannelUserRepository(SimpleChatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<ChannelUserEntity> GetAll()
        {
            return _dbContext.ChannelUsers.ToList();
        }

        public ChannelUserEntity GetById(Guid id)
        {
            return _dbContext.ChannelUsers.FirstOrDefault(s => s.Id == id);
        }

        public void Remove(Guid id)
        {
            ChannelUserEntity entity = _dbContext.ChannelUsers.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                _dbContext.ChannelUsers.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public ChannelUserEntity Add(ChannelUserEntity entity)
        {
            if (entity != null)
            {
                _dbContext.ChannelUsers.Add(entity);
                _dbContext.SaveChanges();
            }
            return entity;
        }

        public void Update(ChannelUserEntity entity)
        {
            if (entity != null)
            {
                _dbContext.ChannelUsers.Update(entity);
                _dbContext.SaveChanges();
            }
        }
    }
}