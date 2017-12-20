using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessCenter.Domain.ViewModel.Account
{
    public class UserViewModel
    {
        public string Id { get; set; }        
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<SelectListItem> Roles { get; set; }
        [Display(Name = "Role")]
        public string RoleId { get; set; }
    }
}
