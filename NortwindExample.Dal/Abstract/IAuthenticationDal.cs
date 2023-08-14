using NortwindExample.Entities;

namespace NortwindExample.Dal
{
    public interface IAuthenticationDal
    {
        User Authenticate(User user);
    }
}