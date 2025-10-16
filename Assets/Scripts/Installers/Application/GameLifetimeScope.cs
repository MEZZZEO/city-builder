using MessagePipe;
using VContainer;
using VContainer.Unity;

namespace Installers.Application
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterMessagePipe();
        }
    }
}