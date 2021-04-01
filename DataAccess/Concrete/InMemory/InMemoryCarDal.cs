using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
         
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId = 1,ColorId = 1,DailyPrice = 575,Description = "Mercedes Benz C 200", ModelYear = 2020},
                new Car{Id=2,BrandId = 2,ColorId = 2,DailyPrice = 255,Description = "Mercedes Benz A180", ModelYear = 2014},
                new Car{Id=3,BrandId = 3,ColorId = 1,DailyPrice = 156,Description = "Opel Corsa Elegance", ModelYear = 2019},
                new Car{Id=4,BrandId = 4,ColorId = 3,DailyPrice = 325,Description = "Opel Insignia", ModelYear = 2015},
                new Car{Id=5,BrandId = 5,ColorId = 2,DailyPrice = 180,Description = "Renault Megane Sedan", ModelYear = 2016},
            };
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
        }
    }
}
