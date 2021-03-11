using Kukshaus.InTime.Data.IssueDataStorage.Contract;
using Kukshaus.InTime.Data.IssueDataStorage.InMemory;
using Ninject.Modules;

namespace Kukshaus.InTime.Infrastructure.Aggregation.Data
{
    internal sealed class IssueDataStorageBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IIssueRepository>().To<InMemoryIssueRepository>();
        }
    }
}