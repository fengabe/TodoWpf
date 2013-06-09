using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace TodoWpf.ViewModel
{
    public class TodoItemViewModel : ViewModelBase
    {
        public TodoItemViewModel()
        {
            LabelClickedCommand = new RelayCommand(() => EditMode = true);
            EnterKeyCommand = new RelayCommand(() => EditMode = false);
            EditMode = false;
        }

        private const string INCOMPLETE_COLOR = "#000000";
        private const string COMPLETE_COLOR = "#BBBBBB";

        private string _description;
        private bool _complete;
        private string _contentColor;
        private bool _editMode;
        private Visibility _labelVisibility;
        private Visibility _textboxVisibility;

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged(() => Description);
            }
        }

        public bool Complete
        {
            get { return _complete; }
            set
            {
                _complete = value;
                RaisePropertyChanged(() => Complete);
                ContentColor = _complete ? COMPLETE_COLOR : INCOMPLETE_COLOR;
            }
        }

        public string ContentColor
        {
            get { return _contentColor; }
            set
            {
                _contentColor = value;
                RaisePropertyChanged(() => ContentColor);
            }
        }

        public RelayCommand LabelClickedCommand { get; set; }

        public RelayCommand EnterKeyCommand { get; set; }

        public bool EditMode
        {
            get { return _editMode; }
            set
            {
                _editMode = value;
                RaisePropertyChanged(() => EditMode);

                if (_editMode)
                {
                    TextboxVisibility = Visibility.Visible;
                    LabelVisibility = Visibility.Hidden;
                }
                else
                {
                    TextboxVisibility = Visibility.Hidden;
                    LabelVisibility = Visibility.Visible;
                }
            }
        }

        public Visibility LabelVisibility
        {
            get { return _labelVisibility; }
            private set
            {
                _labelVisibility = value;
                RaisePropertyChanged(() => LabelVisibility);
            }
        }

        public Visibility TextboxVisibility
        {
            get { return _textboxVisibility; }
            private set
            {
                _textboxVisibility = value;
                RaisePropertyChanged(() => TextboxVisibility);
            }
        }
    }
}
