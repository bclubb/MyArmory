using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyArmory.Models;

namespace MyArmory.Controllers
{
    public class AuthenticationController : Controller
    {
        #region GET Handlers

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Logout()
        {
            // clear the client-side cookie
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Character");
        }

        #endregion

        #region POST Handlers

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public ActionResult Login(UserLoginModel model)
        {
            // validate the provided credentials
            if (ModelState.IsValid && Membership.ValidateUser(model.Username, model.Password))
            {
                // create the client-side cookie
                FormsAuthentication.SetAuthCookie(model.Username, false);

                // redirect to character listing
                return RedirectToAction("Index", "Character");
            }

            // set the login failed error message
            ModelState.AddModelError("", "Login failed");

            return View(model);
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public ActionResult Register(UserRegisterModel model)
        {
            // validate the provided credentials
            if (ModelState.IsValid)
            {
                try
                {
                    // create the user
                    var user = Membership.CreateUser(model.Username, model.Password);

                    // create the client-side cookie
                    FormsAuthentication.SetAuthCookie(user.UserName, false);

                    // redirect to character listing
                    return RedirectToAction("Index", "Character");
                }
                catch (Exception ex)
                {
                    // set the register failed error message
                    ModelState.AddModelError("", ex.Message);
                }
            }

            return View(model);
        }

        #endregion
    }
}
