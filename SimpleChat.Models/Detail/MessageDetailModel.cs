using System;

namespace SimpleChat.Models.Detail
{
    public class MessageDetailModel: BaseDetailModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public UserDetailModel Owner { get; set; }
    }
}