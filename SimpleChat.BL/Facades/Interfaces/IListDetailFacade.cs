using System;
using System.Collections.Generic;
using SimpleChat.Models.Interfaces;

namespace SimpleChat.BL.Facades.Interfaces
{
    public interface IListDetailFacade<TListModel, TDetailModel> : IFacade<TDetailModel>
        where TDetailModel : IDetailModel where TListModel : IListModel
    {
        new IEnumerable<TListModel> GetAll();
        new TListModel GetById(Guid id);
    }
}