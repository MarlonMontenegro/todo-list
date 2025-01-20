using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.Models
{
    public class TodoTask
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty; 
        public string Description { get; set; } = string.Empty;
        public DateTime Created { get; private set; }
        public bool Completed { get; set; }

         public TodoTask(string title, string description)
        {
            Id = new Random().Next(1, 1000);  
            Title = title ?? throw new ArgumentNullException(nameof(title)); 
            Description = description ?? throw new ArgumentNullException(nameof(description)); 
        }

      

    }
}
