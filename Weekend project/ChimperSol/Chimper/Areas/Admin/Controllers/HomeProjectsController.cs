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
    public class HomeProjectsController : Controller
    {
        private ChimperContext db = new ChimperContext();

        // GET: Admin/HomeProjects
        public ActionResult Index()
        {
            return View(db.HomeProjects.ToList());
        }

        // GET: Admin/HomeProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeProjects homeProjects = db.HomeProjects.Find(id);
            if (homeProjects == null)
            {
                return HttpNotFound();
            }
            return View(homeProjects);
        }

        // GET: Admin/HomeProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeProjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,ProjectName,ProjectType")] HomeProjects homeProjects)
        {
            if (ModelState.IsValid)
            {
                db.HomeProjects.Add(homeProjects);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homeProjects);
        }

        // GET: Admin/HomeProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeProjects homeProjects = db.HomeProjects.Find(id);
            if (homeProjects == null)
            {
                return HttpNotFound();
            }
            return View(homeProjects);
        }

        // POST: Admin/HomeProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,ProjectName,ProjectType")] HomeProjects homeProjects)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homeProjects).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homeProjects);
        }

        // GET: Admin/HomeProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeProjects homeProjects = db.HomeProjects.Find(id);
            if (homeProjects == null)
            {
                return HttpNotFound();
            }
            return View(homeProjects);
        }

        // POST: Admin/HomeProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeProjects homeProjects = db.HomeProjects.Find(id);
            db.HomeProjects.Remove(homeProjects);
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
