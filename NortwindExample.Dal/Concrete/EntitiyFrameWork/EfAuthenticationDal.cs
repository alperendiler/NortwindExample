using NortwindExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindExample.Dal.Concrete.EntitiyFrameWork
{
    public class EfAuthenticationDal : IAuthenticationDal
    {
        public User Authenticate(User user)
        {
            //veritabanından alıncacak
            if (user.UserName=="alperen" && user.Password=="1234")
            {
                return user;
            }
            
                return null;
            

        }
    }
}
