using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Commons.Concretes.Helpers;
using CarRentingSystem.Commons.Concretes.Logger;
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
            try
            {
                return db.SaveChanges();
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("MainRepository::Save::Error occured.", ex);
            }
        }

        public List<T> ListAll()
        {
            try
            {
                return DbSet.ToList();
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("MainRepository::List::Error occured.", ex);
            }
        }

        public List<T> ListAll(Expression<Func<T, bool>> expression)
        {
            try
            {
                return DbSet.Where(expression).ToList();
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("MainRepository::ListAll::Error occured.", ex);
            }
        }

        public T Find(int id)
        {
            try
            {
                return DbSet.Find(id);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("MainRepository::Find::Error occured.", ex);
            }
        }

        public T Find(Expression<Func<T, bool>> expression)
        {
            try
            {
                return DbSet.FirstOrDefault(expression);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("MainRepository::FintExpression::Error occured.", ex);
            }
        }

        public int Insert(T entity)
        {
            try
            {
                DbSet.Add(entity);
                return Save();
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("MainRepository::Insert::Error occured.", ex);
            }
        }

        public virtual int Update(T entity)
        {
            try
            {
                DbSet.AddOrUpdate(entity);
                return Save();
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("MainRepository::Update::Error occured.", ex);
            }
        }

        public int Remove(T entity)
        {
            try
            {
                DbSet.Remove(entity);
                return Save();
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("MainRepository::Remove::Error occured.", ex);
            }
        }

    }
}
