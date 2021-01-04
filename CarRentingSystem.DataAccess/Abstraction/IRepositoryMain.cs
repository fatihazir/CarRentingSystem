using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.DataAccess.Abstraction
{
    public interface IRepositoryMain<TEntity> where TEntity : class
    {
        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool DeletedById(int id);
        TEntity SelectedById(int id);
        IList<TEntity> SelectAll();
    }
}
