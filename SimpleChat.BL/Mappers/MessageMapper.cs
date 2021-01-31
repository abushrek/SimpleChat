using SimpleChat.BL.Mappers.Interfaces;
using SimpleChat.DAL.Entities;
using SimpleChat.Models.Detail;
using SimpleChat.Models.Interfaces;
using SimpleChat.Models.List;

namespace SimpleChat.BL.Mappers
{
    public class MessageMapper:IMapper<MessageListModel,MessageEntity>, IMapper<MessageDetailModel,MessageEntity>
    {
        MessageListModel IMapper<MessageListModel, MessageEntity>.MapEntityToModel(MessageEntity entity)
        {
            return new MessageListModel
            {
                Id = entity.Id,
                Content = entity.Content,
                Title = entity.Title
            };
        }

        public MessageEntity MapModelToEntity(MessageDetailModel model)
        {
            return new MessageEntity
            {
                Id = model.Id,
                Content = model.Content,
                Title = model.Title
            };
        }

        public MessageEntity MapModelToEntity(MessageListModel model)
        {
            return new MessageEntity
            {
                Id = model.Id,
                Content = model.Content,
                Title = model.Title
            };
        }

        MessageDetailModel IMapper<MessageDetailModel, MessageEntity>.MapEntityToModel(MessageEntity entity)
        {
            return new MessageDetailModel
            {
                Id = entity.Id,
                Content = entity.Content,
                Title = entity.Title
            };
        }
    }
}