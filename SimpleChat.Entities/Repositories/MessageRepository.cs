using System;
using System.Collections.Generic;
using System.Linq;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories.Interfaces;

namespace SimpleChat.DAL.Repositories
{
    public class MessageRepository:IRepository<MessageEntity>
    {
        private readonly SimpleChatDbContext _dbContext;
        public MessageRepository(SimpleChatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<MessageEntity> GetAll()
        {
            return _dbContext.Messages.ToList();
        }

        public MessageEntity GetById(Guid id)
        {
            return _dbContext.Messages.FirstOrDefault(s => s.Id == id);
        }

        public void Remove(Guid id)
        {
            MessageEntity entity = _dbContext.Messages.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                _dbContext.Messages.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public MessageEntity Insert(MessageEntity entity)
        {
            if (entity != null)
            {
                _dbContext.Messages.Add(entity);
                _dbContext.SaveChanges();
            }
            return entity;
        }

        public void Update(MessageEntity entity)
        {
            if (entity != null)
            {
                _dbContext.Messages.Update(entity);
                _dbContext.SaveChanges();
            }
        }
    }
}