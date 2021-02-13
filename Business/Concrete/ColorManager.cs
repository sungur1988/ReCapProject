using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Concrete.EfCarDal;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class ColorManager : IColorService
    {
        EfColorDal _colordal;

        public ColorManager(EfColorDal colordal)
        {
            _colordal = colordal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colordal.GetAll());
        }


        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colordal.Get(c => c.ColorId == id));
        }
    }
}
