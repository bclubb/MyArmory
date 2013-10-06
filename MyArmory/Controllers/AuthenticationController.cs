using System;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;
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

        #endregion

        #region POST Handlers

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLoginModel model)
        {
            if (ModelState.IsValid && WebSecurity.Login(model.Username, model.Password, true))
                return RedirectToAction("Index", "Character");

            ModelState.AddModelError("", "The username or password is incorrect");

            return View(model);
        }

        #endregion
    }
}
