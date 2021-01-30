using System;
using SimpleChat.Entities.Interfaces;

namespace SimpleChat.Entities
{
    public class BaseEntity:IEntity
    {
        public Guid Id { get; set; }
    }
}