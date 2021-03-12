namespace Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects
{
    public readonly struct IssueStatus : IValueObject
    {
        private readonly int _status;

        public static IssueStatus Backlog { get; } = new IssueStatus(1);
        public static IssueStatus InProgress { get; } = new IssueStatus(2);

        public static IssueStatus Done { get; } = new IssueStatus(9);
        public static IssueStatus Closed { get; } = new IssueStatus(10);

        private IssueStatus(int status)
            => _status = status;

        public static implicit operator int(IssueStatus status)
            => status._status;

        public static implicit operator IssueStatus(int status)
            => new IssueStatus(status);
    }
}