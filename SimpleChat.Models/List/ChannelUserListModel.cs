namespace SimpleChat.Models.List
{
    public class ChannelUserListModel: BaseListModel
    {
        public ChannelListModel Channel { get; set; }
        public UserListModel User { get; set; }
    }
}