using System.Linq;
using SimpleChat.BL.Mappers.Interfaces;
using SimpleChat.DAL.Entities;
using SimpleChat.Models.Detail;
using SimpleChat.Models.List;

namespace SimpleChat.BL.Mappers
{
    public class UserMapper:IMapper<UserDetailModel,UserEntity>, IMapper<UserListModel,UserEntity>
    {
        private readonly IMapper<CredentialsDetailModel, CredentialsEntity> _credentialsMapper;
        private readonly IMapper<ChannelUserListModel, ChannelUserEntity> _channelUserMapper;

        public UserMapper()
        {
            _credentialsMapper = new CredentialsMapper();
            _channelUserMapper = new ChannelUserMapper();
        }

        public UserDetailModel MapEntityToModel(UserEntity entity)
        {
            return new UserDetailModel
            {
                Id = entity.Id,
                Credentials = _credentialsMapper.MapEntityToModel(entity.Credentials),
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                ListOfChanelUser = entity.ListOfChanelUser.Select(s=> _channelUserMapper.MapEntityToModel(s)).ToList(),
            };
        }

        public UserEntity MapModelToEntity(UserListModel model)
        {
            return new UserEntity
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
            };
        }

        public UserEntity MapModelToEntity(UserDetailModel model)
        {
            return new UserEntity
            {
                Id = model.Id,
                Credentials = _credentialsMapper.MapModelToEntity(model.Credentials),
                FirstName = model.FirstName,
                LastName = model.LastName,
                ListOfChanelUser = model.ListOfChanelUser.Select(s => _channelUserMapper.MapModelToEntity(s)).ToList(),
            };
        }

        UserListModel IMapper<UserListModel, UserEntity>.MapEntityToModel(UserEntity entity)
        {
            return new UserListModel
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
            };
        }
    }
}