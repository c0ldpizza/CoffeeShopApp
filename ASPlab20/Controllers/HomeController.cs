using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPlab20.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UserReg()
        {
            return View();
        }

        public ActionResult Submit(string firstname, string lastname, string password, string phone, string email)
        {
            ViewBag.firstname = firstname;
            ViewBag.lastname = lastname;
            ViewBag.password = password;
            ViewBag.phone = phone;
            ViewBag.email = email;
            return View();
        }

        public ActionResult Order()
        {
            return View();
        }
    }
}