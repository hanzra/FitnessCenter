using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessCenter.Domain.Entities.Identity
{
        public class AppUser : IdentityUser
        {
       
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }

            public virtual ICollection<Registration> Registration { get; set; }
        }
}
