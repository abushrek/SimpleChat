using System.Collections.Generic;
using SimpleChat.Models.List;

namespace SimpleChat.Models.Detail
{
    public class ChannelDetailModel:BaseModel
    {
        public string Name { get; set; }
        public UserDetailModel Owner { get; set; }
        public ICollection<ChannelUserListModel> ListOfChanelUser { get; set; }
        public ICollection<MessageDetailModel> ListOfMessages { get; set; }
    }
}