using SimpleChat.DAL.Entities.Interfaces;
using SimpleChat.Models.Interfaces;

namespace SimpleChat.BL.Mappers.Interfaces
{
    public interface IMapper<TModel,TEntity> where TModel:IModel where TEntity: IEntity
    {
        TModel MapEntityToModel(TEntity entity);
        TEntity MapModelToEntity(TModel model);
    }
}