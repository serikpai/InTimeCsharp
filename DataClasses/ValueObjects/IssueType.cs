namespace InTime.CrossCutting.DataClasses.ValueObjects
{
    public class IssueType
    {
        public static IssueType Story { get; } = new IssueType(1);
        public static IssueType Task { get; } = new IssueType(2);
        public static IssueType Bug { get; } = new IssueType(3);

        private readonly int _type;

        private IssueType(int type)
        {
            _type = type;
        }
    }
}