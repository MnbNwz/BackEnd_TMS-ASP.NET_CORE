
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tms.Server.Models
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        public string UserId { get; set; } // Change from int to string

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public int TaskAssignedBy { get; set; }
        [Required]
        public int Assignee { get; set; }

        [Required]
        public DateTime TaskCreated { get; set; }

        [Required]
        public DateTime TaskExpiry { get; set; }

        public string? Tags { get; set; }
        public string? Status { get; set; }

        public string Severity { get; set; }

        public bool IsCompleted { get; set; }
    }
}
