using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EfCarDal
{
    public class EfRentalDal : EfRepositoryBase<Rental,RecapDatabaseContext>, IRentalDal
    {
    }
}
