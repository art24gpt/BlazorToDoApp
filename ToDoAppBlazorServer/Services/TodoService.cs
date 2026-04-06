using ToDoAppBlazorServer.Models;

namespace ToDoAppBlazorServer.Services
{
    public class TodoService : ITodoService
    {
        private readonly IList<TodoItem> _ToDoItems;

        public TodoService()
        {
            _ToDoItems = new List<TodoItem> {
            new TodoItem("Wash Clothes"),
            new TodoItem("Clean Desk")
        };
        }

        public void Add(TodoItem item)
        {
            _ToDoItems.Add(item);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _ToDoItems;
        }

        public void Delete(TodoItem item)
        {
            _ToDoItems.Remove(item);
        }

        public void Complete(TodoItem item)
        {
            item.Completed = true;
        }

        public void Uncomplete(TodoItem item)
        {
            item.Completed = false;
        }
    }
}
