using Microsoft.Extensions.DependencyInjection;

namespace SimpleChat.DAL.Installers
{
    public interface IInstaller
    {
        void Install(IServiceCollection serviceCollection);
    }
}