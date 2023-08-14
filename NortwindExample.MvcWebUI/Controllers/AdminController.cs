using NortwindExample.Entities;
using NortwindExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NortwindExample.MvcWebUI.Controllers
{

    public class AdminController : Controller
    {
        private IProductService _productService;

        public AdminController(IProductService productService)
        {
            _productService = productService;
        }
        
        public ActionResult Index()
        {
             return View(_productService.GetAll());
        }
        [Authorize]
        public ActionResult CreateNew()
        {
            return View(new Product());
        }
        [Authorize]
        [HttpPost]
        public ActionResult CreateNew(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);

                return RedirectToAction("Index");
            }
            return View(product);
        }


        public ActionResult Edit(int productId)
        {
            Product product = _productService.Get(productId);
            return View(new Product()); 
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);

                return RedirectToAction("Index");
            }
            return View(product);
        }

    }
}