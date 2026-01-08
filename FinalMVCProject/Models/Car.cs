using FinalMVCProject.Common;
using System.ComponentModel.DataAnnotations;

namespace FinalMVCProject.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationConstants.Car.BrandMaxLength,
            MinimumLength = ValidationConstants.Car.BrandMinLength)]
        public string Brand { get; set; }

        [Required]
        [StringLength(ValidationConstants.Car.ModelMaxLength,
            MinimumLength = ValidationConstants.Car.ModelMinLength)]
        public string Model { get; set; }

        [Range(ValidationConstants.Car.YearMin,
            ValidationConstants.Car.YearMax)]
        public int Year { get; set; }

        [Required] 
        public int CategoryId { get; set; } 
        public Category Category { get; set; }  
        public string OwnerId { get; set; } 
        public ApplicationUser Owner { get; set; } 
        public int? ManufacturerId { get; set; } 
        public Manufacturer Manufacturer { get; set; } 
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
