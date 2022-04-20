using System;
using System.ComponentModel.DataAnnotations;

namespace Implements.Models
{
    public class Advancements
    {
        public int Id { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public int Grade { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Remark { get; set; }
        [Required]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
