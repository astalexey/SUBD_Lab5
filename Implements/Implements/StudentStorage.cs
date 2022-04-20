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
    public class StudentStorage : IStudentStorage
    {
        public List<StudentVM> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Students
                    .Include(rec => rec.Classes)
                .Select(CreateModel).ToList();
            }
        }

        public List<StudentVM> GetFilteredList(StudentBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Students
                    .Include(rec => rec.Classes)
                    .Where(rec => rec.District == model.District)
                    .Select(CreateModel).ToList();
            }
        }

        public StudentVM GetElement(StudentBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var student = context.Students
                    .Include(rec => rec.Classes)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return student != null ?
                CreateModel(student) : null;
            }
        }

        public void Insert(StudentBM model)
        {
            using (var context = new DataBaseContext())
            {
                context.Students.Add(CreateModel(model, new Student()));
                context.SaveChanges();
            }
        }

        public void Update(StudentBM model)
        {
            using (var context = new DataBaseContext())
            {
                Student element = context.Students.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Студент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(StudentBM model)
        {
            using (var context = new DataBaseContext())
            {
                Student element = context.Students.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Students.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Студент не найден");
                }
            }
        }

        private Student CreateModel(StudentBM model, Student student)
        {
            student.Name = model.Name;
            student.District = model.District;
            student.Foreign_Student = model.Foreign_Student;
            student.ClassesId = model.ClassesId;
            return student;
        }

        private StudentVM CreateModel(Student student)
        {
            return new StudentVM
            {
                Id = student.Id,
                Name = student.Name,
                District = student.District,
                Foreign_Student = student.Foreign_Student,
                ClassesName = student.Classes.Name
            };
        }

        public void UpdateEmployment(StudentBM model)
        {
            using (var context = new DataBaseContext())
            {
                Student element = context.Students.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Студент не найден");
                }
            }
        }
    }
}
