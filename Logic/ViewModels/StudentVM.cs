using System.Collections.Generic;
using System.ComponentModel;

namespace Logic.ViewModels
{
    public class StudentVM
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Район")]
        public string District { get; set; }
        [DisplayName("Иностранный студент")]
        public bool Foreign_Student { get; set; }
        [DisplayName("Название класса")]
        public string ClassesName { get; set; }
    }
}
