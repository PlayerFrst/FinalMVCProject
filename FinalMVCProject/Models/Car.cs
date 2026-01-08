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
    }
}
