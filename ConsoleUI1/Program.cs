using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { CarId = 5, BrandId = 4, ColorId = 2, DailyPrice = 0, Model = "A" });

            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    //Console.WriteLine(car.CarId + "- " + car.Model + " " + car.DailyPrice);

                    Console.WriteLine(car.CarName + " / " + car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
