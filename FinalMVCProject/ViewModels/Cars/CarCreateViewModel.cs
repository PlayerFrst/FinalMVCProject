using System.ComponentModel.DataAnnotations;
using FinalMVCProject.Common;
using FinalMVCProject.Models;

public class CarCreateViewModel
{
    [Required]
    [StringLength(
        ValidationConstants.Car.BrandMaxLength,
        MinimumLength = ValidationConstants.Car.BrandMinLength)]
    public string Brand { get; set; }

    [Required]
    [StringLength(
        ValidationConstants.Car.ModelMaxLength,
        MinimumLength = ValidationConstants.Car.ModelMinLength)]
    public string Model { get; set; }

    [Range(
        ValidationConstants.Car.YearMin,
        ValidationConstants.Car.YearMax)]
    public int Year { get; set; }

    [Required]
    public int CategoryId { get; set; }


    // Dropdown lists
    public IEnumerable<Category> Categories { get; set; }
}
