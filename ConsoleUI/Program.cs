using Business.Concrete;
using DataAccess.Concrete.EfCarDal;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            //carManager.Add(new Car {BrandId=2,ColorId=1,DailyPrice=200000,ModelYear=2019,Description="Jetta" });

            //foreach (var item in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(item.BrandId);
            //}
            var result = carManager.GetCarDetails();
            foreach (var item in result.Data) 
            {
                Console.WriteLine("{0}--{1}--{2}--{3}",item.CarName,item.BrandName,item.ColorName,item.DailyPrice);
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
