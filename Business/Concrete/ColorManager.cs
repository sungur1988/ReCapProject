﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCarDal;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colordal;

        public ColorManager(IColorDal colordal)
        {
            _colordal = colordal;
        }

        public IResult Add(Color color)
        {
            _colordal.Add(color);
            return new SuccessResult(Messages.ColorAddedSuccessMessage);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colordal.GetAll());
        }


        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colordal.Get(c => c.ColorId == id));
        }

        public IResult Update(Color color)
        {
            _colordal.Update(color);
            return new SuccessResult(Messages.ColorUpdatedSuccessMessage);
        }
    }
}
