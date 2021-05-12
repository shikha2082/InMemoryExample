using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Repository<T> : IRepository<T> where T : IStoreable
    {
        private List<T> _entities;

        public Repository()
        {
            _entities = new List<T>();
        }

        public IEnumerable<T> All()
        {
            return _entities;
        }

        public void Delete(IComparable id)
        {
            T item = _entities.FirstOrDefault(p => p.Id == id);
            _entities.Remove(item);
        }

        public void Save(T item)
        {
            _entities.Add(item);
        }

        public T FindById(IComparable id)
        {
            T item = _entities.FirstOrDefault(p => p.Id == id);

            return item;
        }

    }
}
