using SimpleChat.BL.Mappers.Interfaces;
using SimpleChat.DAL.Entities;
using SimpleChat.Models.Detail;
using SimpleChat.Models.List;

namespace SimpleChat.BL.Mappers
{
    public class ChannelUserMapper:IMapper<ChannelUserListModel,ChannelUserEntity>
    {
        private readonly IMapper<ChannelListModel, ChannelEntity> _channelMapper;
        private readonly IMapper<UserListModel, UserEntity> _userMapper;

        public ChannelUserMapper()
        {
            _channelMapper = new ChannelMapper();
            _userMapper = new UserMapper();
        }

        public ChannelUserListModel MapEntityToModel(ChannelUserEntity entity)
        {
            return new ChannelUserListModel
            {
                Id = entity.Id,
                Channel = _channelMapper.MapEntityToModel(entity.Channel),
                User = _userMapper.MapEntityToModel(entity.User)
            };
        }

        public ChannelUserEntity MapModelToEntity(ChannelUserListModel model)
        {
            return new ChannelUserEntity
            {
                Id = model.Id,
                Channel = _channelMapper.MapModelToEntity(model.Channel),
                User = _userMapper.MapModelToEntity(model.User)
            };
        }
    }
}