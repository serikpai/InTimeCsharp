using System.Collections.Generic;
using InTime.CrossCutting.DataClasses.ValueObjects;

namespace InTime.CrossCutting.DataClasses.Aggregates
{
    public class User
    {
        public UserId Id { get; set; }
        public UserName Name { get; set; }
        public Email Email { get; set; }
        public List<IssueId> AssignedIssues { get; set; }
    }
}