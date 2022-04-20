using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;

namespace Logic.Logic
{
    public class SchoolLogic
    {
        private readonly ISchoolStorage _schoolStorage;
        public SchoolLogic(ISchoolStorage schoolStorage)
        {
            _schoolStorage = schoolStorage;
        }
        public List<SchoolVM> Read(SchoolBM model)
        {
            if (model == null)
            {
                return _schoolStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<SchoolVM> { _schoolStorage.GetElement(model) };
            }
            return _schoolStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(SchoolBM model)
        {
            if (model.Id.HasValue)
            {
                _schoolStorage.Update(model);
            }
            else
            {
                _schoolStorage.Insert(model);
            }
        }
        public void Delete(SchoolBM model)

        {
            var element = _schoolStorage.GetElement(new SchoolBM
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Школа не найдена");
            }
            _schoolStorage.Delete(model);
        }
    }
}
