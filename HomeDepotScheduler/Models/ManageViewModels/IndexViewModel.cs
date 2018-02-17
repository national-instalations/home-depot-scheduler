using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HomeDepotScheduler.Models.ValidationAttributes;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDepotScheduler.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }

        [Required]
        [Display(Name = "Is this a home depot account?")]
        public bool BusinessAccount { get; set; } = false;

        [StoreNumber(1)]
        [Display(Name = "Store Number")]
        public string StoreNumber { get; set; } = null;

        [StoreNumber(1)]
        [Display(Name = "Associate Name")]
        public string AssociateName { get; set; }
    }
}
