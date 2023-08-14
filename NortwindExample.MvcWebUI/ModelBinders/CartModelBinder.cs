using NortwindExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using IModelBinder = System.Web.Mvc.IModelBinder;
using ModelBindingContext = System.Web.Mvc.ModelBindingContext;

namespace NortwindExample.MvcWebUI.ModelBinders
{
    public class CartModelBinder : IModelBinder
    {
       

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var cart = (Cart)controllerContext.HttpContext.Session["cart"];
            if (cart == null)
            {
                cart = new Cart();
                controllerContext.HttpContext.Session["cart"]= cart;
            }
            return cart;
        }
    }
}