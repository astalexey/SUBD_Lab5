using System;
using System.ComponentModel;

namespace Logic.ViewModels
{
    public class AdvancementsVM
    {
        public int Id { get; set; }

        [DisplayName("Предмет")]
        public string Subject { get; set; }
        [DisplayName("Оценка")]
        public int Grade { get; set; }
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        [DisplayName("Комментарий")]
        public string Remark { get; set; }
        [DisplayName("Имя студента")]
        public string StudentName { get; set; }
    }
}
