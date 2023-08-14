using NortwindExample.Entities;
using NortwindExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace NortwindExample.MvcWebUI.Controllers
{
    public class AccountController :Controller
    {
        private IAuthenticationService _authencationManager;
public AccountController(IAuthenticationService authencationManager)
        {
            _authencationManager = authencationManager;
        }

        public ActionResult Login()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Login(User user, string retunrnUrl)
        {
            User validatedUser = _authencationManager.Authenticate(user);
            if (validatedUser == null)
            {
                ModelState.AddModelError("Hata", "Kullanıcı Adı Veya Şifresi Yanlış");

            }
            if (ModelState.IsValid)
            {
                if (validatedUser != null)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return Redirect(retunrnUrl);
                }
            }
            
            return View();
        }
        }
    }
