
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        //GetById, GetAll, Add, Update, Delete

        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IDataResult<Car> GetById(int id);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
