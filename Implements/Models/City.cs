using System.ComponentModel.DataAnnotations;

namespace Implements.Models
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        public string Initials { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public int Population { get; set; }
    }
}
