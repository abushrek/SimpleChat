using SimpleChat.BL.Mappers.Interfaces;
using SimpleChat.DAL.Entities;
using SimpleChat.Models.Detail;

namespace SimpleChat.BL.Mappers
{
    public class CredentialsMapper:IMapper<CredentialsDetailModel,CredentialsEntity>
    {
        public CredentialsDetailModel MapEntityToModel(CredentialsEntity entity)
        {
            return new CredentialsDetailModel
            {
                Email = entity.Email,
                Password = entity.Password
            };
        }

        public CredentialsEntity MapModelToEntity(CredentialsDetailModel model)
        {
            return new CredentialsEntity
            {
                Email = model.Email,
                Password = model.Password
            };
        }
    }
}