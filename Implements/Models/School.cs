using System.ComponentModel.DataAnnotations;

namespace Implements.Models
{
    public class School
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int School_Number { get; set; }
        [Required]
        public int Number_Of_Students { get; set; }
        [Required]
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}
