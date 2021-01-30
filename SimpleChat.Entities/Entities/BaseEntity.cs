using System;
using SimpleChat.DAL.Entities.Interfaces;

namespace SimpleChat.DAL.Entities
{
    public class BaseEntity:IEntity
    {
        public Guid Id { get; set; }
    }
}