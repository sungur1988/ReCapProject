using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EfCarDal
{
    public class EfBrandDal : EfRepositoryBase<Brand , RecapDatabaseContext> , IBrandDal
    {
        
    }
}
