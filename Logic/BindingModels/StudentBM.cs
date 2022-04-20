namespace Logic.BindingModels
{
    public class StudentBM
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string District { get; set; }
        public bool Foreign_Student { get; set; }
        public int ClassesId { get; set; }
    }
}
