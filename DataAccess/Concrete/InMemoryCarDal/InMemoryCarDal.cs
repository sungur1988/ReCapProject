using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars = new List<Car>
        {
            new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2016,DailyPrice=200000,Description="Passat"},
            new Car{CarId=2,BrandId=2,ColorId=2,ModelYear=2020,DailyPrice=500000,Description="C180"},
            new Car{CarId=3,BrandId=1,ColorId=3,ModelYear=2017,DailyPrice=150000,Description="Polo"},
            new Car{CarId=4,BrandId=3,ColorId=1,ModelYear=2013,DailyPrice=90000,Description="Corsa"},
        };
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.CarId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpDate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpDate.BrandId = car.BrandId;
            carToUpDate.ColorId = car.ColorId;
            carToUpDate.DailyPrice = car.DailyPrice;
            carToUpDate.Description = car.Description;
        }
    }
}
