using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Abstract.IRepositories
{
    public interface IRepository<T>
    {
        void Create(T item);

        IEnumerable<T> GetItems();
    }
}
