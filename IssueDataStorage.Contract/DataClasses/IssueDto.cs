using System;

namespace Kukshaus.InTime.Data.IssueDataStorage.Contract.DataClasses
{
    public sealed class IssueDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Priority { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}