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

        public async Task<TModel> AddAsync(TModel model, CancellationToken token = default)
        {
            if (model == null)
                throw new ArgumentNullException();
            if (await Repository.AddAsync(_detailMapper.MapModelToEntity(model), token) == null)
            {
                return default;
            }
            return model;
        }

        public void Remove(Guid id)
        {
            Repository.Remove(id);
        }

        public async Task RemoveAsync(Guid id, CancellationToken token = default)
        {
            await Repository.RemoveAsync(id, token);
        }

        public void Update(TModel model)
        {
            if (model == null)
                throw new ArgumentNullException();
            Repository.UpdateAsync(_detailMapper.MapModelToEntity(model));
        }

        public async Task UpdateAsync(TModel model, CancellationToken token = default)
        {
            if (model == null)
                throw new ArgumentNullException();
            await Repository.UpdateAsync(_detailMapper.MapModelToEntity(model), token);
        }

        public IEnumerable<TModel> GetAll()
        {
            return Repository.GetAll().Select(_detailMapper.MapEntityToModel);
        }

        public async Task<IEnumerable<TModel>> GetAllAsync(CancellationToken token = default)
        {
            return (await Repository.GetAllAsync(token)).Select(_detailMapper.MapEntityToModel);
        }

        public TModel GetById(Guid id)
        {
            return _detailMapper.MapEntityToModel(Repository.GetById(id));
        }

        public async Task<TModel> GetByIdAsync(Guid id, CancellationToken token = default)
        {
            return _detailMapper.MapEntityToModel(await Repository.GetByIdAsync(id, token));
        }

        public bool ModelExists(Guid id)
        {
            return Repository.GetAll().Any(s => _detailMapper.MapEntityToModel(s).Id == id);
        }
    }
}