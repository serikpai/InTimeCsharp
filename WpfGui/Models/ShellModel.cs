using System.Collections.Generic;
using Caliburn.Micro;
using Kukshaus.InTime.CrossCutting.DataClasses.Aggregates;

namespace Kukshaus.InTime.Gui.WpfGui.Models
{
    public class ShellModel : PropertyChangedBase
    {
        private IEnumerable<Issue> _openIssues = new List<Issue>();

        public IEnumerable<Issue> OpenIssues
        {
            get => _openIssues;
            set
            {
                if (Equals(value, _openIssues))
                {
                    return;
                }

                _openIssues = value;
                NotifyOfPropertyChange(() => OpenIssues);
            }
        }
    }
}