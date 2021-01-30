using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories.Interfaces;

namespace SimpleChat.DAL.Repositories
{
    public class UserRepository:IRepository<UserEntity>
    {
        private readonly SimpleChatDbContext _dbContext;
        public UserRepository(SimpleChatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<UserEntity> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public UserEntity GetById(Guid id)
        {
            return _dbContext.Users.FirstOrDefault(s => s.Id == id);
        }

        public void Remove(Guid id)
        {
            UserEntity entity = _dbContext.Users.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                _dbContext.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public UserEntity Insert(UserEntity entity)
        {
            if (entity != null)
            {
                _dbContext.Users.Add(entity);
                _dbContext.SaveChanges();
            }
            return entity;
        }

        public void Update(UserEntity entity)
        {
            if (entity != null)
            {
                _dbContext.Users.Update(entity);
                _dbContext.SaveChanges();
            }
        }
    }
}