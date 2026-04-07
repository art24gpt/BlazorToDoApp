using Microsoft.AspNetCore.Components;
using ToDoAppBlazorServer.Models;

namespace ToDoAppBlazorServer.Components
{
    public partial class TodoItemTile : ComponentBase
    {
        [Parameter]
        public required TodoItem TodoItem { get; set; }

        [Parameter]
        public EventCallback<TodoItem> ToggleItem { get; set; }

        [Parameter]
        public EventCallback<TodoItem> DeleteItem { get; set; }

        private string ItemClass(TodoItem item)
            => item.Completed ? "item-completed" : "";
    }
}
