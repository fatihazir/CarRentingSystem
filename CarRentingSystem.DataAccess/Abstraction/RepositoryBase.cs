using CarRentingSystem.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.DataAccess.Concretes
{
    public abstract class RepositoryBase
    {
        protected static CarRentingSystemEntities db;
        private static object obje = new object();

        private static void CreateEntities()
        {
            if (db == null)
            {
                lock (obje)
                {
                    db = new CarRentingSystemEntities();
                }

            }
        }

        public RepositoryBase()
        {
            CreateEntities();
        }
    }
}
