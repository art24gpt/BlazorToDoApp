using System.ComponentModel.DataAnnotations;

namespace ToDoAppBlazorServer.Models
{
    public class TodoItem
    {
        public TodoItem(string text)
        {
            Text = text;
        }

        [Required(ErrorMessage = "New Todo text cannot be empty.")]
        [MaxLength(46, ErrorMessage = "Text is too long. Please use max 46 characters.")]
        public string Text { get; set; }
        public bool Completed { get; set; }
    }
}
