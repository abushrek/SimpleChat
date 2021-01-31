using System;
using SimpleChat.Models.Interfaces;

namespace SimpleChat.Models.Detail
{
    public class BaseDetailModel:IDetailModel
    {
        public Guid Id { get; set; }
    }
}