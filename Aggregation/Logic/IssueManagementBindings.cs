using Kukshaus.InTime.Logic.IssueManagement;
using Kukshaus.InTime.Logic.IssueManagement.Contract;
using Ninject.Modules;

namespace Kukshaus.InTime.Infrastructure.Aggregation.Logic
{
    internal sealed class IssueManagementBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IIssueManager>().To<IssueManager>();
        }
    }
}