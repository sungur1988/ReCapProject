using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length<3)
            {
                Console.WriteLine("Araba ismi minimun 2 karakterden oluşmalıdır.");
            }
            else if (car.DailyPrice<0)
            {
                Console.WriteLine("Araba fiyatı 0'dan büyük olmalıdır.");
            }
            else
            {
                _cardal.Add(car);
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _cardal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _cardal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _cardal.GetAll(p => p.ColorId == id);
        }
    }
}
