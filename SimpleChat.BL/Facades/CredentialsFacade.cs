using System;
using System.Collections.Generic;
using System.Linq;
using SimpleChat.BL.Facades.Interfaces;
using SimpleChat.BL.Mappers;
using SimpleChat.BL.Mappers.Interfaces;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories;
using SimpleChat.DAL.Repositories.Interfaces;
using SimpleChat.Models.Detail;

namespace SimpleChat.BL.Facades
{
    public class CredentialsFacade:BaseFacade<CredentialsDetailModel,CredentialsEntity>
    {
        public CredentialsFacade(IRepository<CredentialsEntity> repository) 
            : base(repository, new CredentialsMapper())
        {
        }
    }
}