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
    public class RealBogsController : Controller
    {
        private ChimperContext db = new ChimperContext();

        // GET: Admin/RealBogs
        public ActionResult Index()
        {
            return View(db.RealBogs.ToList());
        }

        // GET: Admin/RealBogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RealBog realBog = db.RealBogs.Find(id);
            if (realBog == null)
            {
                return HttpNotFound();
            }
            return View(realBog);
        }

        // GET: Admin/RealBogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/RealBogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,AuthorName,Date,Category,Text")] RealBog realBog)
        {
            if (ModelState.IsValid)
            {
                db.RealBogs.Add(realBog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(realBog);
        }

        // GET: Admin/RealBogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RealBog realBog = db.RealBogs.Find(id);
            if (realBog == null)
            {
                return HttpNotFound();
            }
            return View(realBog);
        }

        // POST: Admin/RealBogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,AuthorName,Date,Category,Text")] RealBog realBog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(realBog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(realBog);
        }

        // GET: Admin/RealBogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RealBog realBog = db.RealBogs.Find(id);
            if (realBog == null)
            {
                return HttpNotFound();
            }
            return View(realBog);
        }

        // POST: Admin/RealBogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RealBog realBog = db.RealBogs.Find(id);
            db.RealBogs.Remove(realBog);
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
