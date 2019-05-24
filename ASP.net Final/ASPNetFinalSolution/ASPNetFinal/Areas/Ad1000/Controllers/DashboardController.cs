using ASPNetFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetFinal.Areas.Ad1000.Controllers
{
    public class DashboardController : Controller
    {
        CvDbContext db = new CvDbContext();
        // GET: Ad1000/Dashboard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EditCV()
        {
            var Person = db.Person.FirstOrDefault();
            return View(Person);
        }
    }
}