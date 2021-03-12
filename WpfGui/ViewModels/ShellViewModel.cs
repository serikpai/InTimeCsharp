using System;
using Caliburn.Micro;
using Kukshaus.InTime.CrossCutting.DataClasses.Aggregates;
using Kukshaus.InTime.Gui.WpfGui.Models;
using Kukshaus.InTime.Logic.IssueManagement.Contract;

// 1lI O0
// 0O l1 Z2 S5 G6 B8 71 lI vy hn
// <= => >= - = != == != === !==  111 www

namespace Kukshaus.InTime.Gui.WpfGui.ViewModels
{
    public class ShellViewModel : Screen
    {
        public ShellModel Model { get; set; } = new ShellModel();
        
        private readonly IssueUpsertViewModel _issueUpsertVm;
        private readonly IIssueManager _issueManager;
        private readonly IWindowManager _windowManager;

        public ShellViewModel(IWindowManager windowManager, IssueUpsertViewModel issueUpsertVm,
            IIssueManager issueManager)
        {
            _windowManager = windowManager;
            _issueUpsertVm = issueUpsertVm;
            _issueManager = issueManager;
        }

        public void CreateIssue()
        {
            _issueUpsertVm.InitNew();
            var wasCreated = _windowManager.ShowDialog(_issueUpsertVm);

            if (wasCreated == true)
            {
                Model.OpenIssues = _issueManager.GetUnresolvedIssues();
            }
        }

        public void OpenIssue(Issue issue)
        {
            _issueUpsertVm.InitWith(issue);
            
            var wasCreated = _windowManager.ShowDialog(_issueUpsertVm);

            if (wasCreated == true)
            {
                Model.OpenIssues = _issueManager.GetUnresolvedIssues();
            }
        }
    }
}