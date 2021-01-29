using System.Collections.Generic;
using InTime.CrossCutting.DataClasses.ValueObjects;

namespace InTime.CrossCutting.DataClasses.Aggregates
{
    public class ProjectVersion
    {
        public ProjectVersionId Id { get; set; }
        public VersionName Name { get; set; }
        public List<IssueId> Issues { get; set; }
    }
}