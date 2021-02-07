using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CarManager carManager = new CarManager(new InMemoryDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ID);
                Console.WriteLine(car.BrandID);
                Console.WriteLine(car.ColorID);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine("-------------------------------------------");
            }*/
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //carManager.Add(new Car() { BrandId = 1, ColorId = 2, DailyPrice = 120, ModelYear = 2020, Description = "Car" });
            //carManager.Delete(new Car() { Id = 9 });
           // carManager.Update(new Car() { Id = 10, BrandId = 2, ColorId = 1, DailyPrice = 1200, ModelYear = 2017, Description = "Kral arac" });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId);
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("---------------------------------");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId);
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine("---------------------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine("-------------------------------------------");
            }
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName+" / "+car.BrandName+" / "+car.ColorName+" / "+car.DailyPrice);
            }

        }
    }
}
