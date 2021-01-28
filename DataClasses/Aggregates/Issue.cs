﻿using System;
using System.Collections.Generic;
using InTime.CrossCutting.DataClasses.Entities;
using InTime.CrossCutting.DataClasses.ValueObjects;

namespace InTime.CrossCutting.DataClasses.Aggregates
{
    public class Issue
    {
        public IssueId Id { get; set; }
        public IssueName Name { get; set; }
        public IssuePriority Priority { get; set; }
        public IssueType Type { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public User Reporter { get; set; }
        public User Assignee { get; set; }

        public ProjectVersion AffectVersion { get; set; }
        public ProjectVersion FixVersion { get; set; }

        public TimeValue Estimated { get; set; }
        public TimeValue Logged { get; set; }

        public IssueDescription Description { get; set; }
        
        public List<Issue> SubTasks { get; set; }

        public List<Attachment> Attachments { get; set; }
        public List<Comment> Comments { get; set; }
    }
}