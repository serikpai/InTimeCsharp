using Caliburn.Micro;
using Kukshaus.InTime.CrossCutting.DataClasses.Aggregates;
using Kukshaus.InTime.Gui.WpfGui.Models;
using Kukshaus.InTime.Logic.IssueManagement.Contract;

namespace Kukshaus.InTime.Gui.WpfGui.ViewModels
{
    public sealed class IssueUpsertViewModel : Screen
    {
        internal bool IsClosed { get; private set; }

        private readonly IIssueManager _issueManager;
        public IssueUpsertModel Model { get; set; } = new IssueUpsertModel();

        public IssueUpsertViewModel(IIssueManager issueManager)
            => _issueManager = issueManager;

        public void InitWith(Issue issue)
        {
            Model = new IssueUpsertModel
            {
                Name = issue.Name,
                Description = issue.Description,
                WindowTitle = "Edit issue"
            };
        }

        public void InitNew()
        {
            Model = new IssueUpsertModel();
            Model.WindowTitle = "Create issue";
        }

        public void Create()
        {
            _issueManager.CreateIssue(new Issue
            {
                Name = Model.Name,
                Description = Model.Description
            });

            TryClose(true);
            IsClosed = true;
        }

        public void Update()
        {
            TryClose(true);
            IsClosed = true;
        }

        public void Close()
        {
            if (!Model.IsDirty)
            {
                TryClose(false);
                IsClosed = true;
            }
        }
    }
}