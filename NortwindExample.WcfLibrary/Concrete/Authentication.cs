using NortwindExample.Bll.Concrete;
using NortwindExample.Dal.Concrete.EntitiyFrameWork;
using NortwindExample.Entities;
using NortwindExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindExample.WcfLibrary.Concrete
{
    public class AuthenticationService : IAuthenticationService
    {
        AuthenticationManager _authenticationManager = new AuthenticationManager(new EfAuthenticationDal());
        public User Authenticate(User user)
        {
            return _authenticationManager.Authenticate(user);
        }
    }
}
