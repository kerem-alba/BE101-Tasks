using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Gorev8.Data.Entities
{
    public class StudentEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Classroom { get; set; } = string.Empty;

        [Required, Range(0.00, 4.00, ErrorMessage = "GPA must be between 0.00 and 4.00")]
        public double GPA { get; set; } = 0.0;

    }
    public class StudentEntityConfiguration : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            //Herhangi bir konfigürasyona ihtiyaç olmadı
        }
    }
}