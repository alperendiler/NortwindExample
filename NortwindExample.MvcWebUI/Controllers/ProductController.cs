using NortwindExample.Entities;
using NortwindExample.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NortwindExample.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public int PageSize = 5;
        public ViewResult Index(int page = 1, int category = 0 )
        {
            List<Product> products = _productService.GetAll()
                .Where(p=>p.CategoryID==category||category==0).ToList();
            return View(new ProductViewModel
            {
                Products = products.Skip((page)*PageSize).Take(5).ToList(),
                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = PageSize,
                    TotalItems = products.Count,
                    CurrentPage = page,
                    CurrentCategory = category
                }
            });

        }
    }
}