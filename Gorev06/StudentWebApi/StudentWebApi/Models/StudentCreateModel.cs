using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class StudentCreateModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [RegularExpression(@"^(\d{4})?$", ErrorMessage = "Student number must be a 4-digit number or empty")]

        public string? StudentNo { get; set; }

        [RegularExpression(@"^(\d+-[abcdABCD])?$", ErrorMessage = "Classroom must be in this format: 1-a / 3-d / 8-B or empty")]

        public string? Classroom { get; set; }
    }
}
 