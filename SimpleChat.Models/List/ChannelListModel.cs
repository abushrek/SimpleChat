namespace SimpleChat.Models.List
{
    public class ChannelListModel:BaseModel
    {
        public string Name { get; set; }
        public UserListModel Owner { get; set; }
    }
}