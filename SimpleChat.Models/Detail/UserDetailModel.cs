using System.Collections.Generic;
using SimpleChat.Models.List;

namespace SimpleChat.Models.Detail
{
    public class UserDetailModel:BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CredentialsDetailModel Credentials { get; set; }
        public ICollection<ChannelUserListModel> ListOfChanelUser { get; set; }
    }
}