using System;
using HomeDepotScheduler.Models.ValidationAttributes;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDepotScheduler.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [Required]
        [Display(Name = "Is this a home depot account?")]
        public bool BusinessAccount { get; set; } = false;

        [StoreNumber(0)]
        [Display(Name = "Store Number")]
        public string StoreNumber { get; set; } = null;

        [StoreNumber(0)]
        [Display(Name = "Associate Name")]
        public string AssociateName { get; set; }
    }
}
