using FinalMVCProject.Common;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FinalMVCProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(ValidationConstants.User.FirstNameMaxLength,
            MinimumLength = ValidationConstants.User.FirstNameMinLength)] 
        public string FirstName { get; set; }

        [Required]
        [StringLength(ValidationConstants.User.LastNameMaxLength,
            MinimumLength = ValidationConstants.User.LastNameMinLength)]
        public string LastName { get; set; }

        public ICollection<Car> Cars { get; set; } = new List<Car>(); public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}