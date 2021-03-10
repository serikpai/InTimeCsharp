namespace InTime.CrossCutting.DataClasses.ValueObjects
{
    public struct IssueDescription
    {
        private readonly string _description;

        private IssueDescription(string description)
        {
            _description = description;
        }

        public static implicit operator IssueDescription(string description)
        {
            return new IssueDescription(description);
        }
    }
}