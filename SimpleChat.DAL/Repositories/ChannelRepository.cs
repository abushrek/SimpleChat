using SimpleChat.DAL.Entities;

namespace SimpleChat.DAL.Repositories
{
    public class ChannelRepository : BaseRepository<ChannelEntity>
    {
        public ChannelRepository(SimpleChatDbContext dbContext) : base(dbContext.Channels, dbContext)
        {
        }
    }
}