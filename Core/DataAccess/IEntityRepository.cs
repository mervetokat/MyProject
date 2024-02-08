

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
        //referans ve entity tip olabilir ve entity newlenebilmeli

    {
        //generic constraınt
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//product farklı bir katmndan gel,yor bu yüzden referans olarak entities eklenmeli
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}