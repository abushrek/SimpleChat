using SimpleChat.DAL.Entities;

namespace SimpleChat.DAL.Repositories
{
    public class UserRepository:BaseRepository<UserEntity>
    {
        public UserRepository(SimpleChatDbContext dbContext) : base(dbContext.Users, dbContext)
        {
        }
    }
}