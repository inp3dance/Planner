using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Core.Repositories
{
    public interface IRepository<T> where T : Models.ModelBase
    {
        IEnumerable<T> All { get; set; }

        T FindById(int id);

        void Add(T entity);

        void Remove(T entity);
    }
}
