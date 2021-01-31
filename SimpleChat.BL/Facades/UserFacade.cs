using System;
using System.Collections.Generic;
using System.Linq;
using SimpleChat.BL.Facades.Interfaces;
using SimpleChat.BL.Mappers;
using SimpleChat.BL.Mappers.Interfaces;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories;
using SimpleChat.Models.Detail;
using SimpleChat.Models.List;

namespace SimpleChat.BL.Facades
{
    public class UserFacade:IListDetailFacade<UserListModel,UserDetailModel>
    {
        private readonly UserRepository _repository;
        private readonly IMapper<UserDetailModel, UserEntity> _userDetailMapper;
        private readonly IMapper<UserListModel, UserEntity> _userListMapper;

        public UserFacade(UserRepository repository)
        {
            _userDetailMapper = new UserMapper();
            _userListMapper = new UserMapper();
            _repository = repository;
        }

        public UserDetailModel Add(UserDetailModel model)
        {
            if (_repository.Insert(_userDetailMapper.MapModelToEntity(model)) == null)
                return null;
            return model;
        }

        public void Remove(Guid id)
        {
            _repository.Remove(id);
        }

        public void Update(UserDetailModel model)
        {
            _repository.Update(_userDetailMapper.MapModelToEntity(model));
        }

        IEnumerable<UserListModel> IListDetailFacade<UserListModel, UserDetailModel>.GetAll()
        {
            return _repository.GetAll().Select(s => _userListMapper.MapEntityToModel(s));
        }

        UserListModel IListDetailFacade<UserListModel, UserDetailModel>.GetById(Guid id)
        {
            return _userListMapper.MapEntityToModel(_repository.GetById(id));
        }

        IEnumerable<UserDetailModel> IFacade<UserDetailModel>.GetAll()
        {
            return _repository.GetAll().Select(s => _userDetailMapper.MapEntityToModel(s));
        }

        UserDetailModel IFacade<UserDetailModel>.GetById(Guid id)
        {
            return _userDetailMapper.MapEntityToModel(_repository.GetById(id));
        }
    }
}