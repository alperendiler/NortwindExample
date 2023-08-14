using NortwindExample.Bll.Concrete;
using NortwindExample.Dal.Concrete.EntitiyFrameWork;
using NortwindExample.Entities;
using NortwindExample.Interfaces;
using System.Collections.Generic;

namespace NortwindExample.WcfLibrary.Concrete
{
    internal class ProductService : IProductService
    {
        //Intance Provider ile ezilecek
        ProductManager _productManager = new ProductManager(new EfProductDal());
        public void Add(Product product)
        {
            _productManager.Add(product);
        }

        public void Delete(int productId)
        {
            _productManager.Delete(productId);
        }

        public Product Get(int productId)
        {
            return _productManager.Get(productId);
        }

        public List<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public void Update(Product product)
        {
            _productManager.Update(product);
        }
    }
}
