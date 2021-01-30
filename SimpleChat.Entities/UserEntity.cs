using System.Collections.Generic;

namespace SimpleChat.Entities
{
    public class UserEntity:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CredentialsEntity Credentials { get; set; }
        public ICollection<ChannelUserEntity> ListOfChanelUser { get; set; }
    }
}