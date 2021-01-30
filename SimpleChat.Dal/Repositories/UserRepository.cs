using System;
using System.Collections.Generic;
using SimpleChat.Dal.Repositories.Interfaces;
using SimpleChat.Entities;

namespace SimpleChat.Dal.Repositories
{
    public class UserRepository:IRepository<UserEntity>
    {
        public UserRepository()
        {
            
        }

        public IList<UserEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserEntity GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Insert(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Guid? Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}