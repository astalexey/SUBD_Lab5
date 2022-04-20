using Logic.BindingModels;
using Logic.ViewModels;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface ICityStorage
    {
        List<CityVM> GetFullList();
        List<CityVM> GetFilteredList(CityBM model);
        CityVM GetElement(CityBM model);
        void Insert(CityBM model);
        void Update(CityBM model);
        void Delete(CityBM model);
    }
}
