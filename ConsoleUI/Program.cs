
using Business.Concrete;
using Core.Entities.Concrete;
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
            // CarTest();
              ColorTest();
            //BrandTest();
            //CustomerTest();
            //UserTest();
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 2, CompanyName = "B. LİMİTED A.Ş" });
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { FirstName = "Gözde", LastName = "Toz", Email = "gozdetoz62@gmail.com"});
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
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
            foreach (var car in carManager.GetCarDetailDtos().Data)
            {
                Console.WriteLine(car.CarName +"/"+car.ColorName+"/"+car.BrandName+"/" +car.DailyPrice);

            }
            //carManager.Add(new Car { BrandId = 1, ColorId = 4, DailyPrice = 1500, Description = "Mercedes", ModelYear = 2020 });
            //carManager.Update(new Car { Id = 5 , BrandId = 1, ColorId = 4, DailyPrice = 350, Description = "Mercedes", ModelYear = 2020 });
        }
    }
}
