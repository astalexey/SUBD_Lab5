using System.ComponentModel.DataAnnotations;

namespace Implements.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public bool Foreign_Student { get; set; }
        [Required]
        public int ClassesId { get; set; }
        public virtual Classes Classes { get; set; }
    }
}
