using System.Linq;
using SimpleChat.BL.Mappers.Interfaces;
using SimpleChat.DAL.Entities;
using SimpleChat.Models.Detail;
using SimpleChat.Models.List;

namespace SimpleChat.BL.Mappers
{
    public class ChannelMapper:IMapper<ChannelDetailModel,ChannelEntity>, IMapper<ChannelListModel,ChannelEntity>
    {
        private readonly IMapper<ChannelUserListModel, ChannelUserEntity> _channelUserMapper;
        private readonly IMapper<MessageDetailModel, MessageEntity> _messageMapper;
        private readonly IMapper<UserDetailModel, UserEntity> _userMapper;
        private readonly IMapper<UserListModel, UserEntity> _userListMapper;

        public ChannelMapper()
        {
            _channelUserMapper = new ChannelUserMapper();
            _messageMapper = new MessageMapper();
            _userMapper = new UserMapper();
            _userListMapper = new UserMapper();
        }
        ChannelDetailModel IMapper<ChannelDetailModel, ChannelEntity>.MapEntityToModel(ChannelEntity entity)
        {
            return new ChannelDetailModel
            {
                Id = entity.Id,
                ListOfChanelUser = entity.ListOfChanelUser.Select(s=>_channelUserMapper.MapEntityToModel(s)).ToList(),
                ListOfMessages = entity.ListOfMessages.Select(s=> _messageMapper.MapEntityToModel(s)).ToList(),
                Name = entity.Name,
                Owner = _userMapper.MapEntityToModel(entity.Owner)
            };
        }

        public ChannelEntity MapModelToEntity(ChannelListModel model)
        {
            return new ChannelEntity
            {
                Id = model.Id,
                Name = model.Name,
                Owner = _userListMapper.MapModelToEntity(model.Owner)
            };
        }

        public ChannelEntity MapModelToEntity(ChannelDetailModel model)
        {
            return new ChannelEntity
            {
                Id = model.Id,
                ListOfChanelUser = model.ListOfChanelUser.Select(s => _channelUserMapper.MapModelToEntity(s)).ToList(),
                ListOfMessages = model.ListOfMessages.Select(s => _messageMapper.MapModelToEntity(s)).ToList(),
                Name = model.Name,
                Owner = _userMapper.MapModelToEntity(model.Owner)
            };
        }

        ChannelListModel IMapper<ChannelListModel, ChannelEntity>.MapEntityToModel(ChannelEntity entity)
        {
            return new ChannelListModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Owner = _userListMapper.MapEntityToModel(entity.Owner)
            };
        }
    }
}