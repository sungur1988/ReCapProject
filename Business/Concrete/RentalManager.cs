﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var result = IsRentable(rental.CarId);
            if (!result.Success)
            {
                return new ErrorResult(Messages.RentErrorMessage);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.SuccessMessage);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.Id==id),Messages.SuccessMessage);
        }

        public IResult IsRentable(int id)
        {
            var result = _rentalDal.Get(r => r.CarId == id);
            if (result.ReturnDate==null)
            {
                return new SuccessResult(Messages.SuccessMessage);
            }
            return new ErrorResult(Messages.ErrorMessage);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.SuccessMessage);
        }
    }
}
