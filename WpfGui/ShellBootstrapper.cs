﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Threading;
using Caliburn.Micro;
using Kukshaus.InTime.Gui.WpfGui.ViewModels;
using Kukshaus.InTime.Infrastructure.Aggregation;
using Ninject;

namespace Kukshaus.InTime.Gui.WpfGui
{
    public class ShellBootstrapper : BootstrapperBase
    {
        private IKernel _kernel;

        public ShellBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            _kernel = new StandardKernel(new Aggregator().Modules);

            _kernel.Bind<IWindowManager>().To<WindowManager>();

            DisplayRootViewFor<ShellViewModel>();

            base.OnStartup(sender, e);
        }

        protected override void OnExit(object sender, EventArgs e)
        {
            _kernel.Dispose();

            base.OnExit(sender, e);
        }

        protected override object GetInstance(Type service, string key)
        {
            return _kernel.Get(service);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _kernel.GetAll(service);
        }

        protected override void BuildUp(object instance)
        {
            _kernel.Inject(instance);
        }
        
        protected override void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            var exception = e.Exception.InnerException ?? e.Exception;

            var message = exception.Message;
#if DEBUG
            message += "\r\n" + exception.StackTrace;
#endif

            MessageBox.Show(message, "Issue tracker",
                MessageBoxButton.OK, MessageBoxImage.Error);

            e.Handled = true;
            base.OnUnhandledException(sender, e);
        }
    }
}