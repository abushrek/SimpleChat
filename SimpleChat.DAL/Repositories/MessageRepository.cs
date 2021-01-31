using SimpleChat.DAL.Entities;

namespace SimpleChat.DAL.Repositories
{
    public class MessageRepository:BaseRepository<MessageEntity>
    {
        public MessageRepository(SimpleChatDbContext dbContext) : base(dbContext.Messages, dbContext)
        {
        }
    }
}