using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constaint
    //where T:class,IEntity,new() dediğimizde buradaki "class, referans tip olmalı.IEntity, IEntity olmalı veya IEntity'den implemente edilen bir tip olmalı,new'lenebilir olmalı." anlamındadır.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
