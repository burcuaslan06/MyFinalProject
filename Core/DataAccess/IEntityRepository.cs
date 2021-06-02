using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //veritabanı nesneleri ile çalışan bir repository yapmaya çalışıyoruz.
    //class=referans tip
    //IEntity: IEntity olabilir veya IEntityi implemente eden bir nesne olabilir
    //new((: new lenebilir olmalı . IEntity soyut sınıf interface oldugundan newlenemez. yani sadece somut nesneleri kullanabiliriz.
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}
