using Logic.BindingModels;
using Logic.ViewModels;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface ISchoolStorage
    {
        List<SchoolVM> GetFullList();
        List<SchoolVM> GetFilteredList(SchoolBM model);
        SchoolVM GetElement(SchoolBM model);
        void Insert(SchoolBM model);
        void Update(SchoolBM model);
        void Delete(SchoolBM model);
    }
}
