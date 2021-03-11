using Kukshaus.InTime.Data.IssueDataStorage.Contract;
using Kukshaus.InTime.Data.IssueDataStorage.InMemory;
using Kukshaus.InTime.Data.UserDataStorage.Contract;
using Kukshaus.InTime.Data.UserDataStorage.InMemory;
using Ninject.Modules;

namespace Kukshaus.InTime.Infrastructure.Aggregation.Data
{
    internal sealed class UserDataStorageBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserRepository>().To<InMemoryUserRepository>().InSingletonScope();
            Bind<IProjectVersionRepository>().To<InMemoryProjectVersionRepository>().InSingletonScope();
        }
    }
}