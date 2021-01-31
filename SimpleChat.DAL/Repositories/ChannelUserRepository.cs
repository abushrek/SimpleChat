using SimpleChat.DAL.Entities;

namespace SimpleChat.DAL.Repositories
{
    public class ChannelUserRepository:BaseRepository<ChannelUserEntity>
    {
        public ChannelUserRepository(SimpleChatDbContext dbContext) : base(dbContext.ChannelUsers, dbContext)
        {
        }
    }
}