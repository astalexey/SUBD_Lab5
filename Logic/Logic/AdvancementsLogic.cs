using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;

namespace Logic.Logic
{
    public class AdvancementsLogic
    {
        private readonly IAdvancementsStorage _advancementsStorage;
        public AdvancementsLogic(IAdvancementsStorage advancementsStorage)
        {
            _advancementsStorage = advancementsStorage;
        }
        public List<AdvancementsVM> Read(AdvancementsBM model)
        {
            if (model == null)
            {
                return _advancementsStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<AdvancementsVM> { _advancementsStorage.GetElement(model) };
            }
            return _advancementsStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(AdvancementsBM model)
        {
            if (model.Id.HasValue)
            {
                _advancementsStorage.Update(model);
            }
            else
            {
                _advancementsStorage.Insert(model);
            }
        }
        public void Delete(AdvancementsBM model)

        {
            var element = _advancementsStorage.GetElement(new AdvancementsBM
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Школа не найдена");
            }
            _advancementsStorage.Delete(model);
        }
    }
}
