using Microsoft.EntityFrameworkCore;
using Shop.DAL;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Shop.BLL
{
    public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
    {
        readonly ShopOnlineContext _context;

        public BaseRepository(ShopOnlineContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void Edit(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).AsQueryable();
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }
            return items;
        }

        public T GetByCondition(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public T GetById(int id)
        {
            if (id > 0)
            {
                return _context.Set<T>().Find(id);
            }
            return null;
        }
    }
}
