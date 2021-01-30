using System;
using System.Collections.Generic;
using System.Linq;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories.Interfaces;

namespace SimpleChat.DAL.Repositories
{
    public class ChannelRepository:IRepository<ChannelEntity>
    {
        private readonly SimpleChatDbContext _dbContext;
        public ChannelRepository(SimpleChatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<ChannelEntity> GetAll()
        {
            return _dbContext.Channels.ToList();
        }

        public ChannelEntity GetById(Guid id)
        {
            return _dbContext.Channels.FirstOrDefault(s => s.Id == id);
        }

        public void Remove(Guid id)
        {
            ChannelEntity entity = _dbContext.Channels.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                _dbContext.Channels.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public ChannelEntity Insert(ChannelEntity entity)
        {
            if (entity != null)
            {
                _dbContext.Channels.Add(entity);
                _dbContext.SaveChanges();
            }
            return entity;
        }

        public void Update(ChannelEntity entity)
        {
            if (entity != null)
            {
                _dbContext.Channels.Update(entity);
                _dbContext.SaveChanges();
            }
        }
    }
}