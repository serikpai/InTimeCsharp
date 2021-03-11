using Kukshaus.InTime.CrossCutting.DataClasses.Aggregates;

namespace Kukshaus.InTime.Logic.IssueManagement.Contract
{
    public interface IIssueManager
    {
        void CreateIssue(Issue issue);
    }
}