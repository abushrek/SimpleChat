using SimpleChat.BL.Mappers;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories.Interfaces;
using SimpleChat.Models.Detail;
using SimpleChat.Models.List;

namespace SimpleChat.BL.Facades
{
    public class ChannelFacade:BaseListDetailFacade<ChannelListModel,ChannelDetailModel,ChannelEntity>
    {
        public ChannelFacade(IRepository<ChannelEntity> repository) : 
            base(repository, new ChannelMapper(), new ChannelMapper())
        {
        }
    }
}