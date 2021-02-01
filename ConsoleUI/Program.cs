using Business.Concrete;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            carManager.Add(new Car {CarId=5,BrandId=1,ColorId=7,DailyPrice=200000,ModelYear=2019,Description="Jetta" });
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            carManager.Update(new Car { CarId = 5, BrandId = 1, ColorId = 7, DailyPrice = 200000, ModelYear = 2019, Description = "Jettaa" });
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            carManager.Delete(new Car { CarId = 5, BrandId = 1, ColorId = 7, DailyPrice = 200000, ModelYear = 2019, Description = "Jettaa" });
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("-------------");
            Console.WriteLine(carManager.GetById(1).Description);
        }
    }
}
