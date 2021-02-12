using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint    
    //IEntity: IEntity ya da IEntity implemente eden bir nesne olabilir 
    //class :referans tip, t için bir sınırlandırma yapıyoruz 
    //new() : new 'lenebilir olmalı 
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //filtreler yazabilmemizi oluşturduk
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
