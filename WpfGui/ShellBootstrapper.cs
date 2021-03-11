using System.Windows;
using Kukshaus.InTime.Gui.WpfGui.ViewModels;

namespace Kukshaus.InTime.Gui.WpfGui
{
    public class ShellBootstrapper : Caliburn.Micro.BootstrapperBase
    {
        public ShellBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
            base.OnStartup(sender, e);
        }
    }
}