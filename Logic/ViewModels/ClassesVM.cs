using System.Collections.Generic;
using System.ComponentModel;

namespace Logic.ViewModels
{
    public class ClassesVM
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Куратор")]
        public string Curator { get; set; }
        [DisplayName("Курс")]
        public int Course { get; set; }
        [DisplayName("Специализация")]
        public string Specialization { get; set; }
        [DisplayName("Название школы")]
        public string SchoolName { get; set; }
    }
}
