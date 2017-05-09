using Sistema.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Domain.Core.Repository
{
    public interface IRepository<TEntity, TFilterEntity, TKey>
         where TKey : struct
      
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(TKey key);



        IList<TEntity> Query(TFilterEntity filter);

    }
}
