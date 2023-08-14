using NortwindExample.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace NortwindExample.Interfaces
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Product> GetAll();

        [OperationContract]
        Product Get(int productId);

        [OperationContract]
        void Add(Product product);

        [OperationContract]
        void Delete(int productId);

        [OperationContract]
        void Update(Product product);

    }
}
