using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your about me page.";
            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Message = "Your resume page.";
            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your portfolio page.";
            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Message = "Your blog page.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Sidebar()
        {
            ViewBag.Message = "Your sidebar.";
            return View();
        }
    }
}