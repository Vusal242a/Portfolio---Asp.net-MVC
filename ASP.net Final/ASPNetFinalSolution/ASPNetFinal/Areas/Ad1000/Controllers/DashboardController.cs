using ASPNetFinal.AppCode.Constant;
using ASPNetFinal.AppCode.Filters;
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
    [CVFilterAttribute]
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
            return View();
        }
        public ActionResult AddAcademicBackg()
        {
            return View();
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
        public ActionResult AddDetail(Person Person, HttpPostedFileBase Image)
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
                string i = Image.SaveImage(Server.MapPath("~/Template/Media"));
                P.Image = i;
                P.UpdateDate = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("EditCV");
            }
            if (ModelState.IsValid)
            {
                Person.CreatedDate = DateTime.Now;
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
                S.UpdateDate = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("EditCV");
            }
            if (ModelState.IsValid)
            {
                SocProfil.CreatedDate = DateTime.Now;
                db.SocialProfiles.Add(SocProfil);
                db.SaveChanges();
            }
            return RedirectToAction("EditCV");
        }
        [HttpPost]
        public ActionResult AddProEx(ProfessionalExperience ProfExp, HttpPostedFileBase Image, string fileName)
        {
            if (Image != null)
            {
                bool valid = true;
                if (!Image.CheckImageType())
                {
                    ModelState.AddModelError("mediaUrl", "Şəkil uyğun deyil!");
                    valid = false;
                }

                if (!Image.CheckImageSize(5))
                {
                    ModelState.AddModelError("mediaUrl", "Şəklin ölçüsü uyğun deyil!");
                    valid = false;
                }

                if (valid)
                {
                    string newPath = Image.SaveImage(Server.MapPath("~/Template/Media/"));

                    //System.IO.File.Move(Server.MapPath(System.IO.Path.Combine("~/Template/media", entity.MediaUrl)),
                    //    Server.MapPath(System.IO.Path.Combine("~/Template/media", entity.MediaUrl)));


                    ProfExp.Image = newPath;

                }
            }
            else if (!string.IsNullOrWhiteSpace(ProfExp.Image)
                && !string.IsNullOrWhiteSpace(fileName))
            {
                ProfExp.Image = null;
            }

            if (ModelState.IsValid)
            {
                ProfExp.CreatedDate = DateTime.Now;
                db.ProfessionalExperience.Add(ProfExp);
                db.SaveChanges();
            }
            return RedirectToAction("EditCV");
        }
        [HttpPost]
        public ActionResult AddAcademicBack(AcademicBackground AcBack, HttpPostedFileBase Image, string fileName)
        {
            if (Image != null)
            {
                bool valid = true;
                if (!Image.CheckImageType())
                {
                    ModelState.AddModelError("mediaUrl", "Şəkil uyğun deyil!");
                    valid = false;
                }

                if (!Image.CheckImageSize(5))
                {
                    ModelState.AddModelError("mediaUrl", "Şəklin ölçüsü uyğun deyil!");
                    valid = false;
                }

                if (valid)
                {
                    string newPath = Image.SaveImage(Server.MapPath("~/Template/Media/"));

                    //System.IO.File.Move(Server.MapPath(System.IO.Path.Combine("~/Template/media", entity.MediaUrl)),
                    //    Server.MapPath(System.IO.Path.Combine("~/Template/media", entity.MediaUrl)));


                    AcBack.Image = newPath;

                }
            }
            else if (!string.IsNullOrWhiteSpace(AcBack.Image)
                && !string.IsNullOrWhiteSpace(fileName))
            {
                AcBack.Image = null;
            }

            if (ModelState.IsValid)
            {
                AcBack.CreatedDate = DateTime.Now;
                db.AAcademicBackgroundca.Add(AcBack);
                db.SaveChanges();
            }
            return RedirectToAction("EditCV");
        }
        [HttpPost]
        public ActionResult BioSkills(BioSkills BioSi)
        {
            BioSi.CreatedDate = DateTime.Now;
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
            if (Alogin.Email == Admin.Email && Alogin.Password == Admin.Password)
            {

                Session[SessionKey.Admin] = Admin;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.LoginError = "Email or Password not matched";
                return View();
            }
        }

    }
}