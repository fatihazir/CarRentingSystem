using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.DataAccess.Abstraction
{
    public class DbMain<T> where T : class
    {
        private CarRentingSystemContext db = new CarRentingSystemContext();
        private DbSet<T> DbSet;

        public DbMain()
        {
            DbSet = db.Set<T>();
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public List<T> ListAll()
        {
            return DbSet.ToList();
        }

        public List<T> List(Expression <Func<T,bool>> expression)
        {
            return DbSet.Where(expression).ToList();
        }

        public T Find(int id)
        {
            return  DbSet.Find(id);
        }

        public int Insert(T entity)
        {
            DbSet.Add(entity);
            return Save();
        }

        public int Update(T entity)
        {
            return Save();
        }

        public int Remove(T entity)
        {
            DbSet.Remove(entity);
            return Save();
        }



    }
}
