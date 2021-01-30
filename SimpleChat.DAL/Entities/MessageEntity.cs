using System;

namespace SimpleChat.DAL.Entities
{
    public class MessageEntity:BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public UserEntity Owner { get; set; }
    }
}