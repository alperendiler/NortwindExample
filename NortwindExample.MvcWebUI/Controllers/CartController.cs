using NortwindExample.Entities;
using NortwindExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NortwindExample.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductService _productService; 
        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Cart
        public RedirectToRouteResult AddToCart(Cart cart,int productId)
        {
            Product product = _productService.Get(productId);

          
            cart.AddToCart(product, 1);
            return RedirectToAction("Index",cart);
        }
        public ViewResult Index(Cart cart)
        {
            return View(cart);
        }

        public ActionResult RemoveFromCart(Cart cart,int productId)
        {
            Product product = _productService.Get(productId);

          
                cart.RemoveFromCart(product);

            return View("Index",cart);
        }
        [HttpGet]
        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }
        [HttpPost]
        public ActionResult Checkout(ShippingDetails shippingDetails)
        {
            if (ModelState.IsValid)
            {
                //MAnagerden veri tabanına kayıt sağlanıcak
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            } 
        }


        public PartialViewResult CartSummary(Cart cart)
        {
           
            
            return PartialView(cart);

        }


    }
}