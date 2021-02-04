using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        List<T> GetAll();
        T Get(Expression<Func<T,bool>> filter);
        List<T> GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
