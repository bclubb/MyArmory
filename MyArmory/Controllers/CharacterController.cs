using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyArmoryLibrary;
using MyArmoryLibrary.Models;

namespace MyArmory.Controllers
{
    public class CharacterController : Controller
    {
        public ActionResult Index()
        {
            var db = new ArmoryDatabase("ArmoryDatabase");

            // get all available characters
            ViewBag.characters = db.Characters;

            return View();
        }
    }
}
