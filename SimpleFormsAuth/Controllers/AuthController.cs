using SimpleFormsAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SimpleFormsAuth.Controllers
{
    public class AuthController : Controller
    {

        FormsAuthenticationHelper authentication;

        public AuthController()
        {
            authentication = new FormsAuthenticationHelper();
        }
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if(ModelState.IsValid)
            {
               if(authentication.Authenticate(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));

                }
               else
                {
                    ModelState.AddModelError("", "Incorrect user name or password");
                    return View(model);
                }
            }



            return View(model);
        }



        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }


    }



}