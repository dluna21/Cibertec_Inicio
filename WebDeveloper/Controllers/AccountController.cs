using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Models.Account;

namespace WebDeveloper.Controllers
{
    //Indica que todas las acciones sean logueados
    [Authorize]
    public class AccountController : Controller
    {
        public UserManager<WebDeveloperUser> UserManager { get; private set; }

        public AccountController():this(new UserManager<WebDeveloperUser>
                                       (new UserStore<WebDeveloperUser>
                                       (new WebUserDbContext())))
        {
                   
        }
        public AccountController(UserManager<WebDeveloperUser> usermanager)
        {
            UserManager = usermanager;
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
       }

        [AllowAnonymous]
        public ActionResult Register() {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model) {
            if (ModelState.IsValid)
            {
                var user = new WebDeveloperUser { UserName = model.UserName };
                var result = await UserManager.CreateAsync(user,model.Password);
                if (result.Succeeded) {
                    AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
                    var identity = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthenticationManager.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = false
                    },  identity);
                }
                return RedirectToAction("Index","Home");
                //await espera que termine un metodo asyncrono
            }
            return View(model);
        }

        private IAuthenticationManager AuthenticationManager {
            get {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

    }
}