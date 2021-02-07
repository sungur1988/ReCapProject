using Business.Abstract;
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

        public List<Color> GetAll()
        {
            return _colordal.GetAll();
        }


        public Color GetById(int id)
        {
            return _colordal.Get(c => c.ColorId == id);
        }
    }
}
