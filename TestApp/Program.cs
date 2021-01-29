using System.Collections.Generic;
using InTime.CrossCutting.DataClasses.Aggregates;
using InTime.CrossCutting.DataClasses.ValueObjects;

namespace InTime.Ui.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var issue = new Issue();
            issue.Id = new IssueId(42);
            issue.Priority = IssuePriority.Normal;
            issue.Type = IssueType.Story;
            issue.Name = new IssueName("Share this page");
            issue.Description = new IssueDescription("Share this post on your favorite social media platforms!");

            /*issue.SubTasks = new List<Issue>
            {
                new Issue
                {
                    Name = new IssueName("Shared it on Instagram")
                },
                new Issue()
                {
                    Name = new IssueName("Shared it on Facebook")
                },
                new Issue()
                {
                    Name = new IssueName("Shared it on Twitter")
                },
                new Issue()
                {
                    Name = new IssueName("Shared it on Twitter")
                }
            };/**/
        }
    }
}