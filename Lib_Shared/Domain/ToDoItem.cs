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

    // Todo: Contact Manager | Entry
    public class ContactEntity
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        //public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string HomeAddress { get; set; }
        public string Image { get; set; }
        public bool IsCheck { get; set; }
    }
}
