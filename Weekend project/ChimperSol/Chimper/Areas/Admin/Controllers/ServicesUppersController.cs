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
    public class ServicesUppersController : Controller
    {
        private ChimperContext db = new ChimperContext();

        // GET: Admin/ServicesUppers
        public ActionResult Index()
        {
            return View(db.ServicesUppers.ToList());
        }

        // GET: Admin/ServicesUppers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicesUpper servicesUpper = db.ServicesUppers.Find(id);
            if (servicesUpper == null)
            {
                return HttpNotFound();
            }
            return View(servicesUpper);
        }

        // GET: Admin/ServicesUppers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ServicesUppers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Icon,Title,Text")] ServicesUpper servicesUpper)
        {
            if (ModelState.IsValid)
            {
                db.ServicesUppers.Add(servicesUpper);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicesUpper);
        }

        // GET: Admin/ServicesUppers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicesUpper servicesUpper = db.ServicesUppers.Find(id);
            if (servicesUpper == null)
            {
                return HttpNotFound();
            }
            return View(servicesUpper);
        }

        // POST: Admin/ServicesUppers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Icon,Title,Text")] ServicesUpper servicesUpper)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicesUpper).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicesUpper);
        }

        // GET: Admin/ServicesUppers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicesUpper servicesUpper = db.ServicesUppers.Find(id);
            if (servicesUpper == null)
            {
                return HttpNotFound();
            }
            return View(servicesUpper);
        }

        // POST: Admin/ServicesUppers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServicesUpper servicesUpper = db.ServicesUppers.Find(id);
            db.ServicesUppers.Remove(servicesUpper);
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
