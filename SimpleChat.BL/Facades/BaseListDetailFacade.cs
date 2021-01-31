using System;
using System.Collections.Generic;
using System.Linq;
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

        public new IEnumerable<TListModel> GetAll()
        {
            return Repository.GetAll().Select(s=>_listMapper.MapEntityToModel(s));
        }

        public new TListModel GetById(Guid id)
        {
            return _listMapper.MapEntityToModel(Repository.GetById(id));
        }
    }
}