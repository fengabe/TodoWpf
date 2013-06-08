using GalaSoft.MvvmLight;

namespace TodoWpf.ViewModel
{
    public class TodoItemViewModel : ViewModelBase
    {
        private string _description;
        private bool _complete;
        private string _contentColor;
        private const string INCOMPLETE_COLOR = "#000000";
        private const string COMPLETE_COLOR = "#BBBBBB";
        
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
    }
}
