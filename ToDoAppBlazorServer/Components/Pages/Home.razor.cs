using Microsoft.AspNetCore.Components;
using ToDoAppBlazorServer.Models;

namespace ToDoAppBlazorServer.Components.Pages
{
    public partial class Home : ComponentBase
    {
        private IList<TodoItem> Todos { get; set; } = new List<TodoItem>();

        protected override void OnInitialized()
        {
            Todos = _todoService.GetAll().ToList();
        }

        public string ItemClass(TodoItem item)
        {
            return item.Completed ? "item-completed" : "";
        }

        public void ItemsChanged()
        {
            Todos = _todoService.GetAll().ToList();
            StateHasChanged();
        }

        public void DeleteItem(TodoItem item)
        {
            _todoService.Delete(item);
            ItemsChanged();
        }

        public void ToggleItem(TodoItem item)
        {
            if (item.Completed)
                _todoService.Uncomplete(item);
            else
                _todoService.Complete(item);

            ItemsChanged();
        }

        public void CompleteItem(TodoItem item)
        {
            _todoService.Complete(item);
            ItemsChanged();
        }

        public void UncompleteItem(TodoItem item)
        {
            _todoService.Uncomplete(item);
            ItemsChanged();
        }
    }
}
