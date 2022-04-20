using System.ComponentModel.DataAnnotations;

namespace Implements.Models
{
    public class Classes
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Curator { get; set; }
        [Required]
        public int Course { get; set; }
        [Required]
        public string Specialization { get; set; }
        [Required]
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
    }
}
