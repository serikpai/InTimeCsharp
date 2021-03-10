using System.Collections.Generic;
using Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects;

namespace Kukshaus.InTime.CrossCutting.DataClasses.Aggregates
{
    public class ProjectVersion
    {
        public ProjectVersionId Id { get; set; }
        public VersionName Name { get; set; }
        public List<IssueId> Issues { get; set; }
    }
}