using System.Runtime.InteropServices;
using Caliburn.Micro;

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
            _windowManager.ShowDialog(_issueUpsertVm);
        }
    }
}