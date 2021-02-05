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
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RecapDatabaseContext context = new RecapDatabaseContext())
            {
                var addedBrand = context.Entry(entity);
                addedBrand.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Brand entity)
        {
            using (RecapDatabaseContext context = new RecapDatabaseContext())
            {
                var deletedBrand = context.Entry(entity);
                deletedBrand.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RecapDatabaseContext context = new RecapDatabaseContext())
            {
                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();

            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RecapDatabaseContext context = new RecapDatabaseContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);

            }
        }

        public void Update(Brand entity)
        {
            using (RecapDatabaseContext context = new RecapDatabaseContext())
            {
                var updatedBrand = context.Entry(entity);
                updatedBrand.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
