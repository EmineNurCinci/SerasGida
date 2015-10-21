using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Repo
{
    public abstract class RepositoryBase<T> where T : class
    {
        private static StockContext _context;

        public List<T> GetAll()
        {
            _context = new StockContext();
            return _context.Set<T>().ToList();
        }
        public RepositoryBase()
        {
            if (_context == null)
                _context = new StockContext();
        }

        public static IQueryable<T> AsQueryable()
        {
            return _context.Set<T>();
        }
        public T First(Expression<Func<T, bool>> where)
        {

            return _context.Set<T>().FirstOrDefault<T>(where);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().Where(where);
        }

        public T Delete(T entity)
        {
            return _context.Set<T>().Remove(entity);
        }

        public T Add(T entity)
        {
            return _context.Set<T>().Add(entity);
        }

        public T Attach(T entity)
        {
            return _context.Set<T>().Attach(entity);
        }

        public List<T> List()
        {
            return _context.Set<T>().ToList();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
