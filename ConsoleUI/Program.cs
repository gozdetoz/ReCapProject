
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
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description); 

            //}
            carManager.Add(new Car { BrandId = 1, ColorId = 4, DailyPrice = 1500, Description = "Mercedes", ModelYear = 2020 });


        }
    }
}
