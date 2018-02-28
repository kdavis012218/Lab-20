using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Complete(Register r)
        {
            ViewBag.Message = "Registration Complete.";/*ViewBag simply shows what you ask it*/
            ViewBag.Name = r.Firstname;
            ViewBag.Name = r.lastname;
            return View();/*this code section takes first/last name and adds it to the welcome message*/

        }
        public ActionResult StartPage() => View();
    }
}










