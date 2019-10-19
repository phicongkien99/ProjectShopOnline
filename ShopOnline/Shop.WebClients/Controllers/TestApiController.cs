using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Shop.BLL.Services.Interfaces;
using Shop.DAL.ViewModels;

namespace Shop.WebClients.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class TestApiController : ControllerBase
    //{
    //    private readonly IProductService _productService;

    //    public TestApiController(IProductService productService)
    //    {
    //        _productService = productService;
    //    }

    //    [HttpGet("api/getAllProduct")]
    //    public JToken Get()
    //    {
    //        List<ProductViewModel> listProduct = _productService.GetAll().ToList();
    //        return JToken.FromObject(listProduct);
    //    }
    //}
}