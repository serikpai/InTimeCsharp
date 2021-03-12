using Kukshaus.InTime.CrossCutting.StaticProxying;
using Kukshaus.InTime.CrossCutting.StaticProxying.Contract;
using Ninject.Modules;

namespace Kukshaus.InTime.Infrastructure.Aggregation.CrossCutting
{
    internal sealed class StaticProxyingBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IGuidProxy>().To<GuidProxy>();
            Bind<IDateTimeProxy>().To<DateTimeProxy>();
        }
    }
}