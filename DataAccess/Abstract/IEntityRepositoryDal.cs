using Entities.Abstract;
using System.Linq.Expressions;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepositoryDal<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T , bool>> filter=null);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(Expression<Func<T , bool>> filter);
    }
}
