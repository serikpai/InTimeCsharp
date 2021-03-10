using System;
using Kukshaus.InTime.CrossCutting.DataClasses.Aggregates;
using Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects;

// 1lI O0
// 0O l1 Z2 S5 G6 B8 71 lI vy

namespace InTime.Ui.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var issue = new Issue();
            issue.Id = 1;
            issue.Priority = IssuePriority.Normal;
            issue.Type = IssueType.Story;
            issue.Name = "Share this page";
            issue.Description = "Share this post on your favorite social media platforms!";

            IssueId issueId = 4;
            IssueId issue2 = 4;

            if (issueId.GetHashCode() == issue2.GetHashCode())
            {
                Console.WriteLine("same");
            }
        }
    }
}