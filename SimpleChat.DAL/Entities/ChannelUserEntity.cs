using System;

namespace SimpleChat.DAL.Entities
{
    public class ChannelUserEntity:BaseEntity
    {
        public Guid ChannelId { get; set; }
        public Guid UserId { get; set; }
        public ChannelEntity Channel { get; set; }
        public UserEntity User { get; set; }
    }
}