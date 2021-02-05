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
    class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (RecapDatabaseContext context = new RecapDatabaseContext())
            {
                var addedProduct = context.Entry(entity);
                addedProduct.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (RecapDatabaseContext context = new RecapDatabaseContext())
            {
                var deletedProduct = context.Entry(entity);
                deletedProduct.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RecapDatabaseContext context = new RecapDatabaseContext())
            {
                return filter == null
                    ? context.Set<Color>().ToList()
                    : context.Set<Color>().Where(filter).ToList();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (RecapDatabaseContext context = new RecapDatabaseContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public void Update(Color entity)
        {
            using (RecapDatabaseContext context = new RecapDatabaseContext())
            {
                var updatedProduct = context.Entry(entity);
                updatedProduct.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
