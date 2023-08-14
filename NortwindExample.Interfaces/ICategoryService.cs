using NortwindExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NortwindExample.Interfaces
{
    [ServiceContract]
    public interface ICategoryService
    {
        
            [OperationContract]
            List<Category> GetAll();

        
    }
}
