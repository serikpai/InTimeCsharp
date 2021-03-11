using System.Runtime.InteropServices;
using Caliburn.Micro;

// 1lI O0
// 0O l1 Z2 S5 G6 B8 71 lI vy hn
// <= => >= - = != == != === !==  111 www

namespace Kukshaus.InTime.Gui.WpfGui.ViewModels
{
    public class ShellViewModel : Screen
    {
        private readonly IssueUpsertViewModel _issueUpsertVm;
        private readonly IWindowManager _windowManager;

        public ShellViewModel(IWindowManager windowManager, IssueUpsertViewModel issueUpsertVm)
        {
            _windowManager = windowManager;
            _issueUpsertVm = issueUpsertVm;
        }

        public void Create()
        {
            _issueUpsertVm.InitNew();
            var wasCreated = _windowManager.ShowDialog(_issueUpsertVm);
        }
    }
}