using Caliburn.Micro;
using Kukshaus.InTime.CrossCutting.DataClasses.Aggregates;
using Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects;
using Kukshaus.InTime.Gui.WpfGui.Models;
using Kukshaus.InTime.Logic.IssueManagement.Contract;

namespace Kukshaus.InTime.Gui.WpfGui.ViewModels
{
    public sealed class IssueUpsertViewModel : Screen
    {
        private IssueId _id;

        private readonly IIssueManager _issueManager;
        public IssueUpsertModel Model { get; set; } = new IssueUpsertModel(false);
        internal bool IsClosed { get; private set; }

        public IssueUpsertViewModel(IIssueManager issueManager)
            => _issueManager = issueManager;

        public void InitWith(Issue issue)
        {
            _id = issue.Id;

            Model = new IssueUpsertModel(true)
            {
                Name = issue.Name,
                Description = issue.Description,
                WindowTitle = "Edit issue"
            };
        }

        public void InitNew()
        {
            Model = new IssueUpsertModel(false);
            Model.WindowTitle = "Create issue";
        }

        public void Create()
        {
            _issueManager.Create(new Issue
            {
                Name = Model.Name,
                Description = Model.Description
            });

            TryClose(true);
            IsClosed = true;
        }

        public void Update()
        {
            if (Model.IsDirty)
            {
                var issue = _issueManager.GetById(_id);
                issue.Name = Model.Name;
                issue.Description = Model.Description;

                _issueManager.Save(issue);
            }

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