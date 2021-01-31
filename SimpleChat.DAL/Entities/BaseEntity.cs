using System;
using SimpleChat.DAL.Entities.Interfaces;

namespace SimpleChat.DAL.Entities
{
    public abstract class BaseEntity:IEntity
    {
        public Guid Id { get; set; }
    }
}