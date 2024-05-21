
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace tms.Server.Models
{
    public class ApplicationUser : IdentityUser
    {




        [Column("FullName")]
        public string FullName { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        [Column("DateOfBirth")]
        public DateOnly DateOfBirth { get; set; }
        public int Role { get; set; } //1 admin, 0 userd
        public int Approval { get; set; } //0 No, 1 yes(approved by admin)

    }
}
