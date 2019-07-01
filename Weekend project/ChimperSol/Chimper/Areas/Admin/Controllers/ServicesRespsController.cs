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
    public class ServicesRespsController : Controller
    {
        private ChimperContext db = new ChimperContext();

        // GET: Admin/ServicesResps
        public ActionResult Index()
        {
            return View(db.ServicesResps.ToList());
        }

        // GET: Admin/ServicesResps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicesResp servicesResp = db.ServicesResps.Find(id);
            if (servicesResp == null)
            {
                return HttpNotFound();
            }
            return View(servicesResp);
        }

        // GET: Admin/ServicesResps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ServicesResps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Text")] ServicesResp servicesResp)
        {
            if (ModelState.IsValid)
            {
                db.ServicesResps.Add(servicesResp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicesResp);
        }

        // GET: Admin/ServicesResps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicesResp servicesResp = db.ServicesResps.Find(id);
            if (servicesResp == null)
            {
                return HttpNotFound();
            }
            return View(servicesResp);
        }

        // POST: Admin/ServicesResps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Text")] ServicesResp servicesResp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicesResp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicesResp);
        }

        // GET: Admin/ServicesResps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicesResp servicesResp = db.ServicesResps.Find(id);
            if (servicesResp == null)
            {
                return HttpNotFound();
            }
            return View(servicesResp);
        }

        // POST: Admin/ServicesResps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServicesResp servicesResp = db.ServicesResps.Find(id);
            db.ServicesResps.Remove(servicesResp);
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
