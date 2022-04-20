using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using Implements.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Implements.Implements
{
    public class CityStorage : ICityStorage
    {
        public List<CityVM> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Citys
                .Select(CreateModel).ToList();
            }
        }

        public List<CityVM> GetFilteredList(CityBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Citys
                    .Where(rec => rec.Initials == model.Initials)
                    .Select(CreateModel).ToList();
            }
        }

        public CityVM GetElement(CityBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var city = context.Citys
                .FirstOrDefault(rec => rec.Id == model.Id || rec.Initials == model.Initials);
                return city != null ?
                CreateModel(city) : null;
            }
        }

        public void Insert(CityBM model)
        {
            using (var context = new DataBaseContext())
            {
                context.Citys.Add(CreateModel(model, new City()));
                context.SaveChanges();
            }
        }

        public void Update(CityBM model)
        {
            using (var context = new DataBaseContext())
            {
                var element = context.Citys.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Город не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(CityBM model)
        {
            using (var context = new DataBaseContext())
            {
                City element = context.Citys.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Citys.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Город не найден");
                }
            }
        }

        private City CreateModel(CityBM model, City city)
        {
            city.Initials = model.Initials;
            city.Region = model.Region;
            city.Population = model.Population;
            return city;
        }

        private CityVM CreateModel(City city)
        {
            return new CityVM
            {
                Id = city.Id,
                Initials = city.Initials,
                Region = city.Region,
                Population = city.Population
            };
        }
    }
}
