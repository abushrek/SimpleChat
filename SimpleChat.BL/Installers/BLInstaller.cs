using Microsoft.Extensions.DependencyInjection;
using SimpleChat.BL.Facades;
using SimpleChat.BL.Facades.Interfaces;
using SimpleChat.BL.Mappers;
using SimpleChat.BL.Mappers.Interfaces;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Installers;
using SimpleChat.Models.Detail;
using SimpleChat.Models.List;

namespace SimpleChat.BL.Installers
{
    public class BLInstaller:IInstaller
    {
        public void Install(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMapper<CredentialsDetailModel,CredentialsEntity>, CredentialsMapper>();
            serviceCollection.AddTransient<IMapper<UserDetailModel,UserEntity>, UserMapper>();
            serviceCollection.AddTransient<IMapper<UserListModel,UserEntity>, UserMapper>();
            serviceCollection.AddTransient<IMapper<ChannelDetailModel,ChannelEntity>, ChannelMapper>();
            serviceCollection.AddTransient<IMapper<ChannelListModel, ChannelEntity>, ChannelMapper>();
            serviceCollection.AddTransient<IMapper<ChannelUserListModel,ChannelUserEntity>, ChannelUserMapper>();
            serviceCollection.AddTransient<IMapper<MessageDetailModel,MessageEntity>, MessageMapper>();
            serviceCollection.AddTransient<IMapper<MessageListModel,MessageEntity>, MessageMapper>();

            serviceCollection.AddTransient<IFacade<CredentialsDetailModel>, CredentialsFacade>();
            serviceCollection.AddTransient<IListDetailFacade<ChannelListModel, ChannelDetailModel>, ChannelFacade>();
            serviceCollection.AddTransient<IFacade<ChannelUserListModel>, ChannelUserFacade>();
            serviceCollection.AddTransient<IListDetailFacade<MessageListModel, MessageDetailModel>, MessageFacade>();
            serviceCollection.AddTransient<IListDetailFacade<UserListModel, UserDetailModel>, UserFacade>();
        }
    }
}