using System;
using SimpleChat.Entities.Interfaces;

namespace SimpleChat.Entities
{
    public class ChannelUserEntity:BaseEntity
    {
        public Guid ChannelId { get; set; }
        public Guid UserId { get; set; }
        public ChannelEntity Channel { get; set; }
        public UserEntity User { get; set; }
    }
}