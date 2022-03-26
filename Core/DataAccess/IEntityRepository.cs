using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//Core katmani diger katmanlari referans almaz !!!!

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //generic constraint
        //class: class olabilir demek degil referans tip olabilir demek
        //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne de olabilir
        //new(): new'lenebilir olmali
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        

    }
}
