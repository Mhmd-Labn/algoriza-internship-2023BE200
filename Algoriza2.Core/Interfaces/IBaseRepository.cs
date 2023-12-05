using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Algoriza2.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class 
    {
        T GetById(int id);
        T GetById(int id, params Expression<Func<T, object>>[] includes);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes);

       
        T Add(T entity);
        T Update(T entity);
       // void Delete(int id);
        int Count();
        

    }
    
    
}
