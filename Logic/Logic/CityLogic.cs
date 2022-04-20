using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;

namespace Logic.Logic
{
    public class CityLogic
    {
        private readonly ICityStorage _cityStorage;
        public CityLogic(ICityStorage cityStorage)
        {
            _cityStorage = cityStorage;
        }
        public List<CityVM> Read(CityBM model)
        {
            if (model == null)
            {
                return _cityStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<CityVM> { _cityStorage.GetElement(model) };
            }
            return _cityStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(CityBM model)
        {
            var element = _cityStorage.GetElement(new CityBM
            {
                Initials = model.Initials
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Город с таким названием уже существует");
            }
            if (model.Id.HasValue)
            {
                _cityStorage.Update(model);
            }
            else
            {
                _cityStorage.Insert(model);
            }
        }
        public void Delete(CityBM model)

        {
            var element = _cityStorage.GetElement(new CityBM
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Город не найден");
            }
            _cityStorage.Delete(model);
        }
    }
}
