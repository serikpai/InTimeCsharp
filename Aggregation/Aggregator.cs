using Kukshaus.InTime.Infrastructure.Aggregation.CrossCutting;
using Kukshaus.InTime.Infrastructure.Aggregation.Data;
using Kukshaus.InTime.Infrastructure.Aggregation.Logic;
using Ninject.Modules;

namespace Kukshaus.InTime.Infrastructure.Aggregation
{
    public sealed class Aggregator
    {
        public readonly INinjectModule[] Modules =
        {
            // Data Layer
            new UserDataStorageBindings(), 
            new IssueDataStorageBindings(), 
            
            // Logic Layer
            new IssueManagementBindings(),
            
            // Cross Cutting Layer
            new StaticProxyingBindings()
        };
    }
}