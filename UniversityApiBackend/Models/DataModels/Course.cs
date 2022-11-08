using System.ComponentModel.DataAnnotations;
//using Microsoft.Build.Framework;

namespace UniversityApiBackend.Models.DataModels
{
    
    public enum Level
    {
        Basic,
        Medium,
        Advanced,
        Hard
    }

    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(200)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
        
        public Level Level { get; set; } = Level.Basic;

        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        [Required]
        public Chapter Chapter { get; set; } = new Chapter();

        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
