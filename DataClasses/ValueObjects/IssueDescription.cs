namespace InTime.CrossCutting.DataClasses.ValueObjects
{
    public class IssueDescription
    {
        private readonly string _description;

        public IssueDescription(string description)
        {
            _description = description;
        }
    }
}