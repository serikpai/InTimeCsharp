using Caliburn.Micro;
using Kukshaus.InTime.CrossCutting.DataClasses.Aggregates;
using Kukshaus.InTime.Gui.WpfGui.Models;
using Kukshaus.InTime.Logic.IssueManagement.Contract;

namespace Kukshaus.InTime.Gui.WpfGui.ViewModels
{
    public class IssueUpsertViewModel : Screen
    {
        private readonly IIssueManager _issueManager;
        public IssueUpsertModel Model { get; set; } = new IssueUpsertModel();

        public IssueUpsertViewModel(IIssueManager issueManager)
        {
            _issueManager = issueManager;
        }
        
        public void InitWith(Issue issue)
        {
            Model = new IssueUpsertModel
            {
                Name = issue.Name,
                Description = issue.Description
            };
        }

        public void InitNew()
        {
            Model = new IssueUpsertModel();
        }

        public void Create()
        {
            _issueManager.CreateIssue(new Issue
            {
                Name = Model.Name,
                Description = Model.Description
            });
            
            TryClose(true);
        }

        public void Update()
        {
            TryClose(true);
        }

        public void Close()
        {
            TryClose(false);
        }
    }
}