using Logic.BindingModels;
using Logic.ViewModels;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IClassesStorage
    {
        List<ClassesVM> GetFullList();
        List<ClassesVM> GetFilteredList(ClassesBM model);
        ClassesVM GetElement(ClassesBM model);
        void Insert(ClassesBM model);
        void Update(ClassesBM model);
        void Delete(ClassesBM model);
    }
}
