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
            B

            carManager.Add(new Car {CarId=5,BrandId=1,ColorId=7,DailyPrice=200000,ModelYear=2019,Description="Jetta" });
            
        }
    }
}
