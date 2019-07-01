using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Chimper.DAL;
using Chimper.Models;

namespace Chimper.Areas.Admin.Controllers
{
    public class AboutSayingsController : Controller
    {
        private ChimperContext db = new ChimperContext();

        // GET: Admin/AboutSayings
        public ActionResult Index()
        {
            return View(db.AboutSayings.ToList());
        }

        // GET: Admin/AboutSayings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutSayings aboutSayings = db.AboutSayings.Find(id);
            if (aboutSayings == null)
            {
                return HttpNotFound();
            }
            return View(aboutSayings);
        }

        // GET: Admin/AboutSayings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutSayings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Position,Text")] AboutSayings aboutSayings)
        {
            if (ModelState.IsValid)
            {
                db.AboutSayings.Add(aboutSayings);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutSayings);
        }

        // GET: Admin/AboutSayings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutSayings aboutSayings = db.AboutSayings.Find(id);
            if (aboutSayings == null)
            {
                return HttpNotFound();
            }
            return View(aboutSayings);
        }

        // POST: Admin/AboutSayings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Position,Text")] AboutSayings aboutSayings)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutSayings).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutSayings);
        }

        // GET: Admin/AboutSayings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutSayings aboutSayings = db.AboutSayings.Find(id);
            if (aboutSayings == null)
            {
                return HttpNotFound();
            }
            return View(aboutSayings);
        }

        // POST: Admin/AboutSayings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutSayings aboutSayings = db.AboutSayings.Find(id);
            db.AboutSayings.Remove(aboutSayings);
            db.SaveChanges();
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
