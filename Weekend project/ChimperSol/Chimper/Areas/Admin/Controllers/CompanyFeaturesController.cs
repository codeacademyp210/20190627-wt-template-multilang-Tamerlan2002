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
    public class CompanyFeaturesController : Controller
    {
        private ChimperContext db = new ChimperContext();

        // GET: Admin/CompanyFeatures
        public ActionResult Index()
        {
            return View(db.CompanyFeatures.ToList());
        }

        // GET: Admin/CompanyFeatures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyFeatures companyFeatures = db.CompanyFeatures.Find(id);
            if (companyFeatures == null)
            {
                return HttpNotFound();
            }
            return View(companyFeatures);
        }

        // GET: Admin/CompanyFeatures/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CompanyFeatures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Text")] CompanyFeatures companyFeatures)
        {
            if (ModelState.IsValid)
            {
                db.CompanyFeatures.Add(companyFeatures);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(companyFeatures);
        }

        // GET: Admin/CompanyFeatures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyFeatures companyFeatures = db.CompanyFeatures.Find(id);
            if (companyFeatures == null)
            {
                return HttpNotFound();
            }
            return View(companyFeatures);
        }

        // POST: Admin/CompanyFeatures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Text")] CompanyFeatures companyFeatures)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyFeatures).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(companyFeatures);
        }

        // GET: Admin/CompanyFeatures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyFeatures companyFeatures = db.CompanyFeatures.Find(id);
            if (companyFeatures == null)
            {
                return HttpNotFound();
            }
            return View(companyFeatures);
        }

        // POST: Admin/CompanyFeatures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompanyFeatures companyFeatures = db.CompanyFeatures.Find(id);
            db.CompanyFeatures.Remove(companyFeatures);
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
