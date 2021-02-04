using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SimpleChat.Models.Interfaces;

namespace SimpleChat.BL.Facades.Interfaces
{
    public interface IListDetailFacade<TListModel, TDetailModel> : IFacade<TDetailModel>
        where TDetailModel : IDetailModel where TListModel : IListModel
    {
        IEnumerable<TListModel> GetAllListModels();
        Task<IEnumerable<TListModel>> GetAllListModelsAsync(CancellationToken token = default);
        TListModel GetListModelById(Guid id);
        Task<TListModel> GetListModelByIdAsync(Guid id, CancellationToken token = default);
    }
}