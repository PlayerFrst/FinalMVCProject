using FinalMVCProject.Common;
using System.ComponentModel.DataAnnotations;

namespace FinalMVCProject.Models
{
    public class Review
    {
        public int Id { get; set; }

        [StringLength(ValidationConstants.Review.CommentMaxLength)]
        public string Comment { get; set; }

        [Range(ValidationConstants.Review.MinRating,
            ValidationConstants.Review.MaxRating)] 
        public int Rating { get; set; }

        [Required] 
        public int CarId { get; set; }

        public Car Car { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}