using ASPNetFinal.Models;
using ASPNetFinal.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetFinal.Controllers
{
    public class HomeController : Controller
    {
        CvDbContext db = new CvDbContext();
        
        public ActionResult Index()
        {
            ViewBag.Message = "Your about me page.";
            return View(db.Person.FirstOrDefault());
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
            return View(db.Person.FirstOrDefault());
        }
        public ActionResult Sidebar()
        {
            ViewBag.Message = "Your sidebar.";
            return View(db.Person.FirstOrDefault());
        }
        public ActionResult SocialProfile()
        {
            var SoProfi = db.SocialProfiles.FirstOrDefault();
            return View(SoProfi);
        }
        public ActionResult ReProfExp()
        {
            var ProExp = db.ProfessionalExperience.ToList();
            return View(ProExp);
        }
        public ActionResult AcademBack()
        {
            var Academic = db.AAcademicBackgroundca.ToList();
            return View(Academic);
        }
        public ActionResult BioSkill()
        {
            var bios = db.BioSkills.OrderByDescending(b=> b.AsBar==true).ToList();
            return View(bios);
        }
        [HttpPost]
        public ActionResult Contact(ContactMe emailModel)
        {
            if (emailModel.Name == null || emailModel.Email == null || emailModel.Content == null)
            {
                TempData["fill"] = "Name,Email,and Body must be written";
                return RedirectToAction("Contact");
            }
            if (ModelState.IsValid)
            {
                db.ContactMe.Add(emailModel);
                db.SaveChanges();
                Extension.SendMail(emailModel.Subject, emailModel.Content,emailModel.Email);
                return RedirectToAction("Contact");
            }
            return RedirectToAction("Contact");
        }
    }
}