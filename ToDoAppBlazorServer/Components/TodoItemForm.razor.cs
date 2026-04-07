using Microsoft.AspNetCore.Components;
using ToDoAppBlazorServer.Models;

namespace ToDoAppBlazorServer.Components
{
    public partial class TodoItemForm : ComponentBase
    {
        [Parameter]
        public EventCallback OnItemAdded { get; set; }

        private TodoItem NewItem = new TodoItem(string.Empty);

        public async Task ItemAdded()
        {
            _todoService.Add(new TodoItem(NewItem.Text));

            NewItem = new TodoItem(string.Empty);

            await OnItemAdded.InvokeAsync();
        }
    }
}
