﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.Description.Length<3)
            {
                return new ErrorResult("Araba ismi minimun 2 karakterden oluşmalıdır.");
            }
            else if (car.DailyPrice<0)
            {
                return new ErrorResult("Araba fiyatı 0'dan büyük olmalıdır.");
            }
            else
            {
                _cardal.Add(car);
                return new SuccessResult("Araba başarılı bir şekilde eklendi");
            }
        }

        public IResult Delete(Car car)
        {
            _cardal.Delete(car);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_cardal.Get(c=>c.CarId==id),Messages.SuccessMessage);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetCarDetails(),Messages.SuccessMessage);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(p => p.BrandId == id),Messages.SuccessMessage);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(p => p.ColorId == id),Messages.SuccessMessage);
        }

        public IResult Update(Car car)
        {
            _cardal.Update(car);
            return new SuccessResult(Messages.SuccessMessage);
        }
    }
}
