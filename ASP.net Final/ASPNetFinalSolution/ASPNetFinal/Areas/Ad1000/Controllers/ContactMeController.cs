using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPNetFinal.AppCode.Filters;
using ASPNetFinal.Models;
using ASPNetFinal.Models.Entity;

namespace ASPNetFinal.Areas.Ad1000.Controllers
{

    [CVFilterAttribute]
    public class ContactMeController : Controller
    {
        private CvDbContext db = new CvDbContext();

        // GET: Ad1000/ContactMe
        public ActionResult Index()
        {
            return View(db.ContactMe.OrderByDescending(o => o.IsRead == false).ToList());
        }

        // GET: Ad1000/ContactMe/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactMe contactMe = db.ContactMe.Find(id);
            contactMe.IsRead = true;
            db.SaveChanges();
            if (contactMe == null)
            {
                return HttpNotFound();
            }
            if (Request.IsAjaxRequest())
            {
                var c = db.ContactMe.Find(id);

                return PartialView("~/Areas/Ad1000/Views/ContactMe/ContactReply.cshtml", c);
            }
            return View(contactMe);
        }

        // GET: Ad1000/ContactMe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ad1000/ContactMe/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Subject,Content,Answer,IsRead,CreatedDate,DeletedDate,UpdateDate")] ContactMe contactMe)
        {
            if (ModelState.IsValid)
            {
                db.ContactMe.Add(contactMe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactMe);
        }

        // GET: Ad1000/ContactMe/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactMe contactMe = db.ContactMe.Find(id);
            if (contactMe == null)
            {
                return HttpNotFound();
            }
            return View(contactMe);
        }

        // POST: Ad1000/ContactMe/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Subject,Content,Answer,IsRead,CreatedDate,DeletedDate,UpdateDate")] ContactMe contactMe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactMe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactMe);
        }

        // GET: Ad1000/ContactMe/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactMe contactMe = db.ContactMe.Find(id);
            if (contactMe == null)
            {
                return HttpNotFound();
            }
            return View(contactMe);
        }

        // POST: Ad1000/ContactMe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactMe contactMe = db.ContactMe.Find(id);
            db.ContactMe.Remove(contactMe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Answer(int? id, ContactMe Contact)
        {
            var c = db.ContactMe.Find(id);
            c.Answer = Contact.Answer;
            db.SaveChanges();
            Extension.SendMail(Contact.Subject, Contact.Answer, Contact.Email);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
