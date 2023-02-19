using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public enum Levels
    {
        Basico,
        Intermedio,
        Avanzado,
    }

    public class Course : baseEntity {
        public string Name { get; set; } = string.Empty;

        [MaxLength(280)]
        public string SmallDescription { get; set; } = string.Empty;

        public string LargeDescription { get; set; } = string.Empty;

        public string TargetAudience { get; set; } = string.Empty; 

        public string Requirement { get; set; } = string.Empty;

        public Levels Levels { get; set; }
    }
}
