using Shop.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.BLL
{
    public class UnitOfWork : IUnitOfWork
    {
        private ShopOnlineContext _context;

        public UnitOfWork(ShopOnlineContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
