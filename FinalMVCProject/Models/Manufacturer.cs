using FinalMVCProject.Common;
using System.ComponentModel.DataAnnotations;

namespace FinalMVCProject.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(ValidationConstants.Manufacturer.NameMaxLength,
            MinimumLength = ValidationConstants.Manufacturer.NameMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(ValidationConstants.Manufacturer.CountryMaxLength,
            MinimumLength = ValidationConstants.Manufacturer.CountryMinLength)] 
        public string Country { get; set; }

        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}