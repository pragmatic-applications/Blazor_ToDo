using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } // Title => Entry
        public bool IsDone { get; set; }
    }
}
