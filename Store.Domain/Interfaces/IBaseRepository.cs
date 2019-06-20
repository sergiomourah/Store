using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Insert(TEntity entity);

        TEntity FindById(int id);

        IEnumerable<TEntity> FindAll();

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
