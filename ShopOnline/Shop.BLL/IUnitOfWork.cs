using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.BLL
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
