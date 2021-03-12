using System;
using System.Collections.Generic;
using Kukshaus.InTime.CrossCutting.DataClasses.Entities;
using Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects;

namespace Kukshaus.InTime.CrossCutting.DataClasses.Aggregates
{
    public class Issue
    {
        public IssueId Id { get; set; }
        public IssueName Name { get; set; }
        public IssuePriority Priority { get; set; }
        public IssueType Type { get; set; }
        public IssueStatus Status { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public UserId Reporter { get; set; }
        public UserId Assignee { get; set; }

        public ProjectVersionId AffectVersion { get; set; }
        public ProjectVersionId FixVersion { get; set; }

        public TimeValue Estimated { get; set; }
        public TimeValue Logged { get; set; }

        public IssueDescription Description { get; set; }

        public List<IssueId> SubTasks { get; set; }

        public List<Attachment> Attachments { get; set; }
        public List<Comment> Comments { get; set; }
    }
}