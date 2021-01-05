using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.DataAccess.Abstraction
{
    public interface IRepositoryMain<T>
    { 
        int Save();

        List<T> ListAll();

        List<T> ListAll(Expression<Func<T, bool>> expression);

        int Insert(T entity);

        int Update(T entity);

        int Remove(T entity);

        T Find(Expression<Func<T, bool>> expression);
        IQueryable ListQueryable();

    }
}
