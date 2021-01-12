using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Concretes;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.DataAccess.Abstraction
{
    public abstract class MainRepository<T> : RepositoryBase, IRepositoryMain<T> where T : class
    {
        private DbSet<T> DbSet;

        public MainRepository()
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

        public List<T> ListAll(Expression<Func<T, bool>> expression)
        {
            return DbSet.Where(expression).ToList();
        }

        public T Find(int id)
        {
            return DbSet.Find(id);
        }

        public T Find(Expression<Func<T, bool>> expression)
        {
            return DbSet.FirstOrDefault(expression);
        }

        public int Insert(T entity)
        {
            DbSet.Add(entity);
            return Save();
        }

        public virtual int Update(T entity)
        {
            DbSet.AddOrUpdate(entity);
            return Save();
        }

        public int Remove(T entity)
        {
            DbSet.Remove(entity);
            return Save();
        }

    }
}
