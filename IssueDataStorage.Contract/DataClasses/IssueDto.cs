using System;

namespace Kukshaus.InTime.Data.IssueDataStorage.Contract.DataClasses
{
    public sealed class IssueDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}