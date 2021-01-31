using SimpleChat.BL.Mappers;
using SimpleChat.BL.Mappers.Interfaces;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories.Interfaces;
using SimpleChat.Models.List;

namespace SimpleChat.BL.Facades
{
    public class ChannelUserFacade:BaseFacade<ChannelUserListModel,ChannelUserEntity>
    {
        public ChannelUserFacade(IRepository<ChannelUserEntity> repository)
            : base(repository, new ChannelUserMapper())
        {
        }
    }
}