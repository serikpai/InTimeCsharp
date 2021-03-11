using Caliburn.Micro;

namespace Kukshaus.InTime.Gui.WpfGui.Models
{
    public sealed class IssueUpsertModel : PropertyChangedBase
    {
        private string _description = string.Empty;
        private string _name = string.Empty;
        private string _windowTitle = string.Empty;

        public string WindowTitle
        {
            get => _windowTitle;
            set => Set(ref _windowTitle, value);
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value == _name)
                {
                    return;
                }

                _name = value;
                IsDirty = true;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (value == _description)
                {
                    return;
                }

                _description = value;
                IsDirty = true;
                NotifyOfPropertyChange(() => Description);
            }
        }

        public bool IsDirty { get; private set; }
    }
}