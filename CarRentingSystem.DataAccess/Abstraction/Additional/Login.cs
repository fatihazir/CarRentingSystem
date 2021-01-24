using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.DataAccess.Abstraction.Additional
{
    public interface Login<T> where T:class
    {
        T Login(string username, string password);
    }
}
