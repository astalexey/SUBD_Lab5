using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;

namespace Logic.Logic
{
    public class StudentLogic
    {
        private readonly IStudentStorage _studentStorage;
        public StudentLogic(IStudentStorage studentStorage)
        {
            _studentStorage = studentStorage;
        }
        public List<StudentVM> Read(StudentBM model)
        {
            if (model == null)
            {
                return _studentStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<StudentVM> { _studentStorage.GetElement(model) };
            }
            return _studentStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(StudentBM model)
        {
            if (model.Id.HasValue)
            {
                _studentStorage.Update(model);
            }
            else
            {
                _studentStorage.Insert(model);
            }
        }
        public void Delete(StudentBM model)

        {
            var element = _studentStorage.GetElement(new StudentBM
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Студент не найден");
            }
            _studentStorage.Delete(model);
        }
    }
}
