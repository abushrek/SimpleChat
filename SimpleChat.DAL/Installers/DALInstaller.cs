using Microsoft.Extensions.DependencyInjection;
using SimpleChat.DAL.Entities;
using SimpleChat.DAL.Repositories;
using SimpleChat.DAL.Repositories.Interfaces;

namespace SimpleChat.DAL.Installers
{
    public class DALInstaller:IInstaller
    {
        public void Install(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IRepository<CredentialsEntity>, CredentialsRepository>();
            serviceCollection.AddTransient<IRepository<ChannelEntity>, ChannelRepository>();
            serviceCollection.AddTransient<IRepository<ChannelUserEntity>, ChannelUserRepository>();
            serviceCollection.AddTransient<IRepository<MessageEntity>, MessageRepository>();
            serviceCollection.AddTransient<IRepository<UserEntity>, UserRepository>();
        }
    }
}