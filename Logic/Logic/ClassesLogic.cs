using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;

namespace Logic.Logic
{
    public class ClassesLogic
    {
        private readonly IClassesStorage _classesStorage;
        public ClassesLogic(IClassesStorage classesStorage)
        {
            _classesStorage = classesStorage;
        }
        public List<ClassesVM> Read(ClassesBM model)
        {
            if (model == null)
            {
                return _classesStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ClassesVM> { _classesStorage.GetElement(model) };
            }
            return _classesStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(ClassesBM model)
        {
            if (model.Id.HasValue)
            {
                _classesStorage.Update(model);
            }
            else
            {
                _classesStorage.Insert(model);
            }
        }
        public void Delete(ClassesBM model)

        {
            var element = _classesStorage.GetElement(new ClassesBM
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Класс не найдена");
            }
            _classesStorage.Delete(model);
        }
    }
}
