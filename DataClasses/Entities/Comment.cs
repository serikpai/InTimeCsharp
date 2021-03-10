using System;
using InTime.CrossCutting.DataClasses.ValueObjects;

namespace InTime.CrossCutting.DataClasses.Entities
{
    public class Comment : ILocalEntity
    {
        public CommentId Id { get; }
        public UserId User { get; }
        public IssueId Issue { get; }
        public DateTime CreationTime { get; }
        public CommentText Content { get; private set; }

        public Comment(UserId user, IssueId issue)
        {
            User = user;
            Issue = issue;
            CreationTime = DateTime.UtcNow;
        }

        public Comment(CommentId id, UserId user, IssueId issue, DateTime creationTime)
        {
            Id = id;
            User = user;
            Issue = issue;
            CreationTime = creationTime;
        }

        public void SetContent(CommentText content)
        {
            Content = content;
        }
    }
}