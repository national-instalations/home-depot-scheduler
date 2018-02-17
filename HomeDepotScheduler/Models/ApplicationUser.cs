using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace HomeDepotScheduler.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        [Required]
        public bool BusinessAccount { get; set; }
        public string StoreNumber { get; set; }
        public string AssociateName { get; set; }
    }
}
