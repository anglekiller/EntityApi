using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityframworkCodeFirst.Interface
{
 
        public interface IRepository<T> : IRepository<T, int> where T : class, IEntity<int>
        {
        }

    public interface IRepository<T, T1> where T : class, IEntity<int>
    {
    }
}
