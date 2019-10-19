using Shop.BLL.Repositories.Interfaces;
using Shop.DAL;
using Shop.DAL.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.BLL.Repositories.Implements
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ShopOnlineContext context) : base(context)
        {
        }
    }
}
