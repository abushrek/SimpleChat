﻿using System;
using System.Collections.Generic;
using System.Linq;
using SimpleChat.BL.Facades.Interfaces;
using SimpleChat.BL.Mappers;
using SimpleChat.BL.Mappers.Interfaces;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories;
using SimpleChat.DAL.Repositories.Interfaces;
using SimpleChat.Models.Detail;
using SimpleChat.Models.List;

namespace SimpleChat.BL.Facades
{
    public class UserFacade:BaseListDetailFacade<UserListModel,UserDetailModel,UserEntity>
    {
        public UserFacade(IRepository<UserEntity> repository) 
            : base(repository, new UserMapper(), new UserMapper())
        {
        }
    }
}