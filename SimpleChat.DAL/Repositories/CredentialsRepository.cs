using SimpleChat.DAL.Entities;

namespace SimpleChat.DAL.Repositories
{
    public class CredentialsRepository:BaseRepository<CredentialsEntity>
    {
        public CredentialsRepository(SimpleChatDbContext dbContext) : base(dbContext.Credentials, dbContext)
        {
        }
    }
}