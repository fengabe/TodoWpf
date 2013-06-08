using System.Collections.Generic;
using System.Collections.ObjectModel;
using AutoMapper;
using GalaSoft.MvvmLight;
using TodoWpf.Business;

namespace TodoWpf.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly ITodoRepository _todoRepository;

        public MainWindowViewModel(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
            LoadTodos();
        }

        private void LoadTodos()
        {
            var todos = _todoRepository.GetAll();
            var todoViewModels = Mapper.Map<IEnumerable<TodoItemViewModel>>(todos);
            TodoItems = new ObservableCollection<TodoItemViewModel>(todoViewModels);
        }

        public ObservableCollection<TodoItemViewModel> TodoItems { get; set; }
    }
}
