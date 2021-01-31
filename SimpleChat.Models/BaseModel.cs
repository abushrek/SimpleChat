using System;
using SimpleChat.Models.Interfaces;

namespace SimpleChat.Models
{
    public abstract class BaseModel : IModel
    {
        public Guid Id { get; set; }
    }
}