using System.Collections.Generic;
using Kukshaus.InTime.CrossCutting.DataClasses.Aggregates;
using Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects;

namespace Kukshaus.InTime.Logic.IssueManagement.Contract
{
    public interface IIssueManager
    {
        IReadOnlyList<Issue> GetUnresolvedIssues();
        void Create(Issue issue);
        Issue GetById(IssueId id);
        void Save(Issue issue);
    }
}