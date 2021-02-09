
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             CarTest();
            // ColorTest();
            //BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);

            }
            //foreach (var color in colorManager.GetById(2))
            //{
            //    Console.WriteLine(color.Name);

            //}
            //colorManager.Add(new Color { Name = "Turkuaz" });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.CarName +"/"+car.ColorName+"/"+car.BrandName+"/" +car.DailyPrice);

            }
            //carManager.Add(new Car { BrandId = 1, ColorId = 4, DailyPrice = 1500, Description = "Mercedes", ModelYear = 2020 });
            //carManager.Update(new Car { Id = 5 , BrandId = 1, ColorId = 4, DailyPrice = 350, Description = "Mercedes", ModelYear = 2020 });
        }
    }
}
