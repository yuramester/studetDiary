using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace studetDiary
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}