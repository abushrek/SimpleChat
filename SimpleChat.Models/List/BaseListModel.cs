using System;
using SimpleChat.Models.Interfaces;

namespace SimpleChat.Models.List
{
    public class BaseListModel:IListModel
    {
        public Guid Id { get; set; }
    }
}