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
    public class SpecialitiesController : Controller
    {
        private ChimperContext db = new ChimperContext();

        // GET: Admin/Specialities
        public ActionResult Index()
        {
            return View(db.Specialities.ToList());
        }

        // GET: Admin/Specialities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Specialities specialities = db.Specialities.Find(id);
            if (specialities == null)
            {
                return HttpNotFound();
            }
            return View(specialities);
        }

        // GET: Admin/Specialities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Specialities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Icon,Title,Text")] Specialities specialities)
        {
            if (ModelState.IsValid)
            {
                db.Specialities.Add(specialities);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(specialities);
        }

        // GET: Admin/Specialities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Specialities specialities = db.Specialities.Find(id);
            if (specialities == null)
            {
                return HttpNotFound();
            }
            return View(specialities);
        }

        // POST: Admin/Specialities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Icon,Title,Text")] Specialities specialities)
        {
            if (ModelState.IsValid)
            {
                db.Entry(specialities).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(specialities);
        }

        // GET: Admin/Specialities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Specialities specialities = db.Specialities.Find(id);
            if (specialities == null)
            {
                return HttpNotFound();
            }
            return View(specialities);
        }

        // POST: Admin/Specialities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Specialities specialities = db.Specialities.Find(id);
            db.Specialities.Remove(specialities);
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
