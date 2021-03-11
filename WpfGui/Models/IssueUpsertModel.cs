using Caliburn.Micro;

namespace Kukshaus.InTime.Gui.WpfGui.Models
{
    public sealed class IssueUpsertModel : PropertyChangedBase
    {
        private string _description = string.Empty;
        private string _name = string.Empty;

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public string Description
        {
            get => _description;
            set => Set(ref _description, value);
        }
    }
}