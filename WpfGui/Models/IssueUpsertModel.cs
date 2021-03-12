using Caliburn.Micro;

namespace Kukshaus.InTime.Gui.WpfGui.Models
{
    public sealed class IssueUpsertModel : PropertyChangedBase
    {
        private string _description = string.Empty;
        private string _name = string.Empty;
        private string _windowTitle = string.Empty;
        private bool _isEditorMode;
        private bool _isCreationMode;

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

        public bool IsCreationMode
        {
            get => _isCreationMode;
            set => Set(ref _isCreationMode, value);
        }

        public bool IsEditorMode
        {
            get => _isEditorMode;
            set => Set(ref _isEditorMode, value);
        }

        public IssueUpsertModel(bool editorMode)
        {
            IsCreationMode = !editorMode;
            IsEditorMode = editorMode;
        }
    }
}