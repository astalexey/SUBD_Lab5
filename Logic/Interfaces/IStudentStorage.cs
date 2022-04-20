using Logic.BindingModels;
using Logic.ViewModels;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IStudentStorage
    {
        List<StudentVM> GetFullList();
        List<StudentVM> GetFilteredList(StudentBM model);
        StudentVM GetElement(StudentBM model);
        void Insert(StudentBM model);
        void Update(StudentBM model);
        void Delete(StudentBM model);
    }
}
