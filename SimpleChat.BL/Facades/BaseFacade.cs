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
    public abstract class BaseFacade <TModel, TEntity> : IFacade<TModel>  where TEntity: IEntity where TModel:IModel
    {
        protected readonly IRepository<TEntity> Repository;
        private readonly IMapper<TModel,TEntity> _detailMapper;

        protected BaseFacade(IRepository<TEntity> repository, IMapper<TModel, TEntity> detailMapper)
        {
            Repository = repository;
            _detailMapper = detailMapper;
        }
        
        public TModel Add(TModel model)
        {
            if(model == null)
                throw new ArgumentNullException();
            if (Repository.Add(_detailMapper.MapModelToEntity(model)) == null)
                return default;
            return model;
        }

        public void Remove(Guid id)
        {
            Repository.Remove(id);
        }

        public void Update(TModel model)
        {
            if (model == null)
                throw new ArgumentNullException();
            Repository.Update(_detailMapper.MapModelToEntity(model));
        }

        public IEnumerable<TModel> GetAll()
        {
            return Repository.GetAll().Select(s => _detailMapper.MapEntityToModel(s));
        }

        public TModel GetById(Guid id)
        {
            return _detailMapper.MapEntityToModel(Repository.GetById(id));
        }
    }
}