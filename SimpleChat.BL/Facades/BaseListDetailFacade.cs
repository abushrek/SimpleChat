using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SimpleChat.BL.Facades.Interfaces;
using SimpleChat.BL.Mappers.Interfaces;
using SimpleChat.DAL.Entities.Interfaces;
using SimpleChat.DAL.Repositories.Interfaces;
using SimpleChat.Models.Interfaces;

namespace SimpleChat.BL.Facades
{
    public abstract class BaseListDetailFacade <TListModel,TDetailModel,TEntity> :BaseFacade<TDetailModel,TEntity>, IListDetailFacade<TListModel,TDetailModel>
        where TDetailModel:IDetailModel where TListModel:IListModel where TEntity:IEntity
    {
        private readonly IMapper<TListModel, TEntity> _listMapper;

        protected BaseListDetailFacade(IRepository<TEntity> repository, IMapper<TDetailModel, TEntity> detailMapper, IMapper<TListModel, TEntity> listMapper) : base(repository, detailMapper)
        {
            this._listMapper = listMapper;
        }

        public IEnumerable<TListModel> GetAllListModels()
        {
            return Repository.GetAll().Select(_listMapper.MapEntityToModel);
        }

        public async Task<IEnumerable<TListModel>> GetAllListModelsAsync(CancellationToken token = default)
        {
            return (await Repository.GetAllAsync(token)).Select(_listMapper.MapEntityToModel);
        }

        public TListModel GetListModelById(Guid id)
        {
            return _listMapper.MapEntityToModel(Repository.GetById(id));
        }

        public async Task<TListModel> GetListModelByIdAsync(Guid id, CancellationToken token = default)
        {
            return _listMapper.MapEntityToModel(await Repository.GetByIdAsync(id, token));
        }
    }
}