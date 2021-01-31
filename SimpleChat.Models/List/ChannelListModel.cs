namespace SimpleChat.Models.List
{
    public class ChannelListModel:BaseListModel
    {
        public string Name { get; set; }
        public UserListModel Owner { get; set; }
    }
}