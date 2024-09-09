using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventTracker.Models
{
    public class EventModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(10)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Range(typeof(DateTime), "2024-01-01", "2025-01-01", ErrorMessage = "Please select a date within 2024")]
        public DateTime Date { get; set; }

    }
}
