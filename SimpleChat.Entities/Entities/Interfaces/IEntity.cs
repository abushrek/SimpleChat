using System;

namespace SimpleChat.DAL.Entities.Interfaces
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}