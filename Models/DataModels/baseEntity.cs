using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class baseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }
        public string DeleteBy { get; set; } = string.Empty;
        public DateTime? DeletedAt { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
