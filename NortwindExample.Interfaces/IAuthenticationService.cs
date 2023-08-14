using NortwindExample.Entities;
using System.ServiceModel;

namespace NortwindExample.Interfaces
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        User Authenticate(User user);
    }
}