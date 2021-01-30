using System.Collections.Generic;

namespace SimpleChat.Entities
{
    public class ChannelEntity:BaseEntity
    {
        public string Name { get; set; }
        public UserEntity Owner { get; set; }
        public ICollection<ChannelUserEntity> ListOfChanelUser { get; set; }
        public ICollection<MessageEntity> ListOfMessages { get; set; }
    }
}