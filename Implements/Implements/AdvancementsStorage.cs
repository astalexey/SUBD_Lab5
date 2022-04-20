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
    public class AdvancementsStorage : IAdvancementsStorage
    {
        public List<AdvancementsVM> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Advancementses
                    .Include(rec => rec.Student)
                .Select(CreateModel).ToList();
            }
        }

        public List<AdvancementsVM> GetFilteredList(AdvancementsBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Advancementses
                    .Include(rec => rec.Student)
                    .Where(rec => rec.Grade == model.Grade)
                    .Select(CreateModel).ToList();
            }
        }

        public AdvancementsVM GetElement(AdvancementsBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var advancements = context.Advancementses
                    .Include(rec => rec.Student)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return advancements != null ?
                CreateModel(advancements) : null;
            }
        }

        public void Insert(AdvancementsBM model)
        {
            using (var context = new DataBaseContext())
            {
                context.Advancementses.Add(CreateModel(model, new Advancements()));
                context.SaveChanges();
            }
        }

        public void Update(AdvancementsBM model)
        {
            using (var context = new DataBaseContext())
            {
                Advancements element = context.Advancementses.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Оценка не найдена");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(AdvancementsBM model)
        {
            using (var context = new DataBaseContext())
            {
                Advancements element = context.Advancementses.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Advancementses.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Оценка не найдена");
                }
            }
        }

        private Advancements CreateModel(AdvancementsBM model, Advancements advancements)
        {
            advancements.Subject = model.Subject;
            advancements.Grade = model.Grade;
            advancements.Date = model.Date;
            advancements.Remark = model.Remark;
            advancements.StudentId = model.StudentId;
            return advancements;
        }

        private AdvancementsVM CreateModel(Advancements advancements)
        {
            return new AdvancementsVM
            {
                Id = advancements.Id,
                Subject = advancements.Subject,
                Grade = advancements.Grade,
                Date = advancements.Date,
                Remark = advancements.Remark,
                StudentName = advancements.Student.Name
            };
        }

        public void UpdateEmployment(AdvancementsBM model)
        {
            using (var context = new DataBaseContext())
            {
                Advancements element = context.Advancementses.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Оценка не найдена");
                }
            }
        }
    }
}
