namespace Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects
{
    public readonly struct IssueType : IValueObject
    {
        private readonly int _type;
        public static IssueType Story { get; } = new IssueType(1);
        public static IssueType Task { get; } = new IssueType(2);
        public static IssueType Bug { get; } = new IssueType(3);

        private IssueType(int type)
            => _type = type;

        public static implicit operator int(IssueType type)
            => type._type;

        public static implicit operator IssueType(int type)
            => new IssueType(type);
    }
}