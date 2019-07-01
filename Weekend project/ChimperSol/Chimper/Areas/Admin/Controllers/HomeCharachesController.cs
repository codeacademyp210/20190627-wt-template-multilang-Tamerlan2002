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
    public class HomeCharachesController : Controller
    {
        private ChimperContext db = new ChimperContext();

        // GET: Admin/HomeCharaches
        public ActionResult Index()
        {
            return View(db.HomeCharaches.ToList());
        }

        // GET: Admin/HomeCharaches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeCharach homeCharach = db.HomeCharaches.Find(id);
            if (homeCharach == null)
            {
                return HttpNotFound();
            }
            return View(homeCharach);
        }

        // GET: Admin/HomeCharaches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeCharaches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Icon,Title,Text")] HomeCharach homeCharach)
        {
            if (ModelState.IsValid)
            {
                db.HomeCharaches.Add(homeCharach);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homeCharach);
        }

        // GET: Admin/HomeCharaches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeCharach homeCharach = db.HomeCharaches.Find(id);
            if (homeCharach == null)
            {
                return HttpNotFound();
            }
            return View(homeCharach);
        }

        // POST: Admin/HomeCharaches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Icon,Title,Text")] HomeCharach homeCharach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homeCharach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homeCharach);
        }

        // GET: Admin/HomeCharaches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeCharach homeCharach = db.HomeCharaches.Find(id);
            if (homeCharach == null)
            {
                return HttpNotFound();
            }
            return View(homeCharach);
        }

        // POST: Admin/HomeCharaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeCharach homeCharach = db.HomeCharaches.Find(id);
            db.HomeCharaches.Remove(homeCharach);
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
