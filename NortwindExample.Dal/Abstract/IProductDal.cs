using NortwindExample.Entities;
using System.Collections.Generic;

namespace NortwindExample.Dal.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();

        Product Get(int productId);

        void Add(Product product);

        void Update(Product product);

        void Delete(int productId);



    }
}
