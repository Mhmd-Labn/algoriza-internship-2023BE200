using Algoriza2.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Algoriza2.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected Context _context;
        public BaseRepository(Context context) 
        {
            _context = context;
        }
      
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public T GetById(int id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return query.ToList();
        }

        public T Add(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
            return item;
        }
        public T Update(T item)
        {
            _context.Set<T>().Update(item);
            return item;
        }
      /*  public void Delete(T entity) 
        {
            _context.Set<T>().Remove(entity);
        }*/
        public int Count()
        {
            return _context.Set<T>().Count();
        }
     



    }
}
