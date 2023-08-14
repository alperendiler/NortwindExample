using NortwindExample.Dal.Abstract;
using NortwindExample.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NortwindExample.Dal.Concrete.EntitiyFrameWork
{
    public class EfProductDal : IProductDal
    {
        ExampleContext _context = new ExampleContext();
        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Get(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.ProductID == productId);
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

        }

        public void Delete(int productId)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(p => p.ProductID == productId));
        }

        public void Update(Product product)
        {
            Product productToUpdate = _context.Products.FirstOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;



        }


    }
}
