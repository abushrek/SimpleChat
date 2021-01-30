namespace SimpleChat.Models.List
{
    public class ChannelUserListModel:BaseModel
    {
        public ChannelListModel Channel { get; set; }
        public UserListModel User { get; set; }
    }
}