using System.ComponentModel;

namespace Logic.ViewModels
{
    public class SchoolVM
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Номер школы")]
        public int School_Number { get; set; }
        [DisplayName("Количество студентов")]
        public int Number_Of_Students { get; set; }
        [DisplayName("Название города")]
        public string CityName { get; set; }
    }
}
