using ASPNetFinal.AppCode.Constant;
using ASPNetFinal.Models;
using ASPNetFinal.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetFinal.Areas.Ad1000.Controllers
{

   [CvAuthorizationAttribute]
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
        public ActionResult AddDetails()
        {
            var Person = db.Person.FirstOrDefault();
            return View(Person);
        }
        public ActionResult AddBioSkill()
        {
            var Bios = db.BioSkills.ToList();
            return View(Bios);
        }
        public ActionResult AddSocialProfiles()
        {
            var SoProf = db.SocialProfiles.FirstOrDefault();
            return View(SoProf);
        }
        public ActionResult AddProExp()
        {
            var ProfEXP = db.ProfessionalExperience.ToList();
            return View(ProfEXP);
        }
        public ActionResult AddAcademicBackg()
        {
            var ACAD = db.AAcademicBackgroundca.ToList();
            return View(ACAD);
        }
        public ActionResult Catego()
        {
            var Categ = db.Category.ToList();
            return View(Categ);
        }
        public ActionResult Skills()
        {
            var Skill = db.Skills.ToList();
            return View(Skill);
        }

        [HttpPost]
        public ActionResult AddDetail(Person Person)
        {
            if (db.Person.Any())
            {
                var P = db.Person.FirstOrDefault();
                P.Age = Person.Age;
                P.CareerLevel = Person.CareerLevel;
                P.Degree = Person.Degree;
                P.Email = Person.Email;
                P.Experience = Person.Experience;
                P.Fax = Person.Fax;
                P.Image = Person.Image;
                P.Location = Person.Location;
                P.Name = Person.Name;
                P.Phone = Person.Phone;
                P.Website = Person.Website;
                //db.Entry(P).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("EditCV");
            }
            if (ModelState.IsValid)
            {
                db.Person.Add(Person);
                db.SaveChanges();
            }
            return RedirectToAction("EditCV");
        }
        [HttpPost]
        public ActionResult AddSocialProfile(SocialProfiles SocProfil)
        {
            if (db.SocialProfiles.Any())
            {
                var S = db.SocialProfiles.FirstOrDefault();
                S.Facebook = SocProfil.Facebook;
                S.Google = SocProfil.Google;
                S.LinkedIn = SocProfil.LinkedIn;
                S.Stumbleupon = SocProfil.Stumbleupon;
                S.Twitter = SocProfil.Twitter;
                S.Dribble = SocProfil.Dribble;
                S.Behance = SocProfil.Behance;
                db.SaveChanges();
                return RedirectToAction("EditCV");
            }
            if (ModelState.IsValid)
            {
                db.SocialProfiles.Add(SocProfil);
                db.SaveChanges();
            }
            return RedirectToAction("EditCV");
        }
        [HttpPost]
        public ActionResult AddProEx(ProfessionalExperience ProfExp)
        {
            if (ModelState.IsValid)
            {
                db.ProfessionalExperience.Add(ProfExp);
                db.SaveChanges();
            }
            return RedirectToAction("EditCV");
        }
        [HttpPost]
        public ActionResult AddAcademicBack(AcademicBackground AcBack)
        {
            if (ModelState.IsValid)
            {
                db.AAcademicBackgroundca.Add(AcBack);
                db.SaveChanges();
            }
            return RedirectToAction("EditCV");
        }
        [HttpPost]
        public ActionResult BioSkills(BioSkills BioSi)
        {
                db.BioSkills.Add(BioSi);
                db.SaveChanges();
            
            return RedirectToAction("EditCV");
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }


        [AllowAnonymous]

        [HttpPost]
        public ActionResult Login(Admin Admin)
        {
            var Alogin = db.Admin.FirstOrDefault();
            if (Alogin.Email==Admin.Email && Alogin.Password== Admin.Password)
            {

                Session[SessionKey.Admin] = Admin;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.LoginError ="Email or Password not matched";
                return View();
            }
        }
    }
}