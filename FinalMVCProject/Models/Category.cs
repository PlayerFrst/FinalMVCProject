using FinalMVCProject.Common;
using System.ComponentModel.DataAnnotations;

namespace FinalMVCProject.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationConstants.Category.NameMaxLength,
            MinimumLength = ValidationConstants.Category.NameMinLength)]
        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
