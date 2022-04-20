using System.Collections.Generic;
using System.ComponentModel;

namespace Logic.ViewModels
{
    public class CityVM
    {
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Initials { get; set; }
        [DisplayName("Регион")]
        public string Region { get; set; }
        [DisplayName("Население")]
        public int Population { get; set; }
    }
}
