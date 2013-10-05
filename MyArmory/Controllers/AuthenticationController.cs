using System;
using System.Web;
using System.Web.Mvc;

namespace MyArmory.Controllers
{
    public class AuthenticationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
