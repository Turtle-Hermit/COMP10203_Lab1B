using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP10203_Lab1B.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Company { get; set; }

        public string Position { get; set; }

        [Required]
        public string Birthdate { get; set; }
    }
}
