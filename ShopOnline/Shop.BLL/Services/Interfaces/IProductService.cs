using Shop.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.BLL.Services.Interfaces
{
    public interface IProductService
    {
        void Add(ProductViewModel products);

        void Update(ProductViewModel products);

        void Delete(ProductViewModel products);

        ProductViewModel GetById(int id);

        IQueryable<ProductViewModel> GetAll();

        void SaveChange();
    }
}
