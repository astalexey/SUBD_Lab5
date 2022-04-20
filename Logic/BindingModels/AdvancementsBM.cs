using System;
namespace Logic.BindingModels
{
    public class AdvancementsBM
    {
        public int? Id { get; set; }
        public string Subject { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }
        public string Remark { get; set; }
        public int StudentId { get; set; }
    }
}
