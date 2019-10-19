using AutoMapper;
using Shop.BLL.Repositories.Interfaces;
using Shop.BLL.Services.Interfaces;
using Shop.DAL.Entitys;
using Shop.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.BLL.Services.Implements
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(ProductViewModel product)
        {
            var model = _mapper.Map<ProductViewModel, Product>(product);
            _productRepository.Add(model);
        }

        public void Delete(ProductViewModel product)
        {
            var model = _mapper.Map<ProductViewModel, Product>(product);
            _productRepository.Delete(model);
        }

        public IQueryable<ProductViewModel> GetAll()
        {
            var listModel = _productRepository.GetAll();
            return _mapper.ProjectTo<ProductViewModel>(listModel);
        }

        public ProductViewModel GetById(int id)
        {
            var model = _productRepository.GetById(id);
            return _mapper.Map<Product, ProductViewModel>(model);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductViewModel product)
        {
            var model = _mapper.Map<ProductViewModel, Product>(product);
            _productRepository.Edit(model);
        }
    }
}
