using Store.Domain.Interfaces;
using Store.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Repository.Repository
{
    public class BaseRespository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly StoreContext StoreContext;


        public BaseRespository(StoreContext storeContext)
        {
            StoreContext = storeContext;
        }

        public void Insert(TEntity entity)
        {
            StoreContext.Set<TEntity>().Add(entity);
            StoreContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            StoreContext.Set<TEntity>().Update(entity);
            StoreContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            StoreContext.Set<TEntity>().Remove(entity);
            StoreContext.SaveChanges();
        }

        public IEnumerable<TEntity> FindAll()
        {
            return StoreContext.Set<TEntity>().ToList();
        }

        public TEntity FindById(int id)
        {
            return StoreContext.Set<TEntity>().Find(id);
        }

        public void Dispose()
        {
            StoreContext.Dispose();
        }
    }
}
