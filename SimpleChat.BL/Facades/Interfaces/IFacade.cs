using System;
using System.Collections.Generic;
using SimpleChat.Models.Interfaces;

namespace SimpleChat.BL.Facades.Interfaces
{
    public interface IFacade<TModel> where TModel:IModel
    {
        TModel Add(TModel model);
        void Remove(Guid id);
        void Update(TModel model);
        IEnumerable<TModel> GetAll();
        TModel GetById(Guid id);
    }
}