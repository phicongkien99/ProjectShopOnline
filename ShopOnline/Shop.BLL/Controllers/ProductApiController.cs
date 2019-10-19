using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Shop.BLL.Services.Interfaces;
using Shop.DAL.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Shop.BLL.Controllers
{
    public class ProductApiController : BaseAPIController
    {
        private readonly IProductService _productService;

        public ProductApiController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("api/getAllProduct")]
        public JToken Get()
        {
            List<ProductViewModel> listProduct = _productService.GetAll().ToList();
            return JToken.FromObject(listProduct);
        }
    }
}
