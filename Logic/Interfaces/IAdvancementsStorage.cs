using Logic.BindingModels;
using Logic.ViewModels;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IAdvancementsStorage
    {
        List<AdvancementsVM> GetFullList();
        List<AdvancementsVM> GetFilteredList(AdvancementsBM model);
        AdvancementsVM GetElement(AdvancementsBM model);
        void Insert(AdvancementsBM model);
        void Update(AdvancementsBM model);
        void Delete(AdvancementsBM model);
    }
}
