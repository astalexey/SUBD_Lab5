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
    public class ClassesStorage : IClassesStorage
    {
        public List<ClassesVM> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Classeses
                    .Include(rec => rec.School)
                .Select(CreateModel).ToList();
            }
        }

        public List<ClassesVM> GetFilteredList(ClassesBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Classeses
                    .Include(rec => rec.School)
                    .Where(rec => rec.Course == model.Course)
                    .Select(CreateModel).ToList();
            }
        }

        public ClassesVM GetElement(ClassesBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var classes = context.Classeses
                    .Include(rec => rec.School)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return classes != null ?
                CreateModel(classes) : null;
            }
        }

        public void Insert(ClassesBM model)
        {
            using (var context = new DataBaseContext())
            {
                context.Classeses.Add(CreateModel(model, new Classes()));
                context.SaveChanges();
            }
        }

        public void Update(ClassesBM model)
        {
            using (var context = new DataBaseContext())
            {
                Classes element = context.Classeses.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Класс не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(ClassesBM model)
        {
            using (var context = new DataBaseContext())
            {
                Classes element = context.Classeses.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Classeses.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Класс не найден");
                }
            }
        }

        private Classes CreateModel(ClassesBM model, Classes classes)
        {
            classes.Name = model.Name;
            classes.Curator = model.Curator;
            classes.Course = model.Course;
            classes.Specialization = model.Specialization;
            classes.SchoolId = model.SchoolId;
            return classes;
        }

        private ClassesVM CreateModel(Classes classes)
        {
            return new ClassesVM
            {
                Id = classes.Id,
                Name = classes.Name,
                Curator = classes.Curator,
                Course = classes.Course,
                Specialization = classes.Specialization,
                SchoolName = classes.School.Name
            };
        }

        public void UpdateEmployment(ClassesBM model)
        {
            using (var context = new DataBaseContext())
            {
                Classes element = context.Classeses.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Класс не найден");
                }
            }
        }
    }
}
