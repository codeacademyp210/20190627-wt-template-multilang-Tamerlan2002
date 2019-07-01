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
    public class MoreInfoesController : Controller
    {
        private ChimperContext db = new ChimperContext();

        // GET: Admin/MoreInfoes
        public ActionResult Index()
        {
            return View(db.MoreInfos.ToList());
        }

        // GET: Admin/MoreInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoreInfo moreInfo = db.MoreInfos.Find(id);
            if (moreInfo == null)
            {
                return HttpNotFound();
            }
            return View(moreInfo);
        }

        // GET: Admin/MoreInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/MoreInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Text")] MoreInfo moreInfo)
        {
            if (ModelState.IsValid)
            {
                db.MoreInfos.Add(moreInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(moreInfo);
        }

        // GET: Admin/MoreInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoreInfo moreInfo = db.MoreInfos.Find(id);
            if (moreInfo == null)
            {
                return HttpNotFound();
            }
            return View(moreInfo);
        }

        // POST: Admin/MoreInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Text")] MoreInfo moreInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moreInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(moreInfo);
        }

        // GET: Admin/MoreInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoreInfo moreInfo = db.MoreInfos.Find(id);
            if (moreInfo == null)
            {
                return HttpNotFound();
            }
            return View(moreInfo);
        }

        // POST: Admin/MoreInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MoreInfo moreInfo = db.MoreInfos.Find(id);
            db.MoreInfos.Remove(moreInfo);
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
