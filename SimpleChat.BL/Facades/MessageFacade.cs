using System;
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
    public class MessageFacade:BaseListDetailFacade<MessageListModel,MessageDetailModel,MessageEntity>
    {
        public MessageFacade(IRepository<MessageEntity> repository) 
            : base(repository, new MessageMapper(), new MessageMapper())
        {
        }
    }
}