using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarId = 5, BrandId = 4, ColorId = 2, DailyPrice = 0, Model = "A" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + "- " + car.Model + " " + car.DailyPrice);
            }
            
        }
    }
}
