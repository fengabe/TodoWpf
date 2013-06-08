using System.Collections.Generic;
using TodoWpf.Model;

namespace TodoWpf.Business
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> GetAll();
    }

    public class TodoRepository : ITodoRepository
    {
        public IEnumerable<TodoItem> GetAll()
        {
            return new List<TodoItem>
            {
                new TodoItem {Description = "Wash the dog", Complete = false},
                new TodoItem {Description = "Make WPF app", Complete = true}
            };
        }
    }
}
