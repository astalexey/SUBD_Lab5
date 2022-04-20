using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using Implements.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Implements.Implements
{
    public class SchoolStorage : ISchoolStorage
    {
        public List<SchoolVM> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Schooles
                    .Include(rec => rec.City)
                .Select(CreateModel).ToList();
            }
        }

        public List<SchoolVM> GetFilteredList(SchoolBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Schooles
                    .Include(rec => rec.City)
                    .Where(rec => rec.Name == model.Name)
                    .Select(CreateModel).ToList();
            }
        }

        public SchoolVM GetElement(SchoolBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var school = context.Schooles
                    .Include(rec => rec.City)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return school != null ?
                CreateModel(school) : null;
            }
        }

        public void Insert(SchoolBM model)
        {
            using (var context = new DataBaseContext())
            {
                context.Schooles.Add(CreateModel(model, new School()));
                context.SaveChanges();
            }
        }

        public void Update(SchoolBM model)
        {
            using (var context = new DataBaseContext())
            {
                School element = context.Schooles.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Школа не найдена");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(SchoolBM model)
        {
            using (var context = new DataBaseContext())
            {
                School element = context.Schooles.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Schooles.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Школа не найдена");
                }
            }
        }

        private School CreateModel(SchoolBM model, School school)
        {
            school.Name = model.Name;
            school.School_Number= model.School_Number;
            school.Number_Of_Students = model.Number_Of_Students;
            school.CityId = model.CityId;
            return school;
        }

        private SchoolVM CreateModel(School school)
        {
            return new SchoolVM
            {
                Id = school.Id,
                Name = school.Name,
                School_Number = school.School_Number,
                Number_Of_Students = school.Number_Of_Students,
                CityName = school.City.Initials
            };
        }

        public void UpdateEmployment(SchoolBM model)
        {
            using (var context = new DataBaseContext())
            {
                School element = context.Schooles.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Школа не найдена");
                }
            }
        }
    }
}
