﻿using System.ComponentModel.DataAnnotations.Schema;

namespace tms.Server.DTOs
{
    public class SignUpDTO
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int Role { get; set; }
    }
}
