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
    public class HomeBlogsController : Controller
    {
        private ChimperContext db = new ChimperContext();

        // GET: Admin/HomeBlogs
        public ActionResult Index()
        {
            return View(db.HomeBlogs.ToList());
        }

        // GET: Admin/HomeBlogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeBlog homeBlog = db.HomeBlogs.Find(id);
            if (homeBlog == null)
            {
                return HttpNotFound();
            }
            return View(homeBlog);
        }

        // GET: Admin/HomeBlogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeBlogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,AuthorName,Date,Category,Text")] HomeBlog homeBlog)
        {
            if (ModelState.IsValid)
            {
                db.HomeBlogs.Add(homeBlog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homeBlog);
        }

        // GET: Admin/HomeBlogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeBlog homeBlog = db.HomeBlogs.Find(id);
            if (homeBlog == null)
            {
                return HttpNotFound();
            }
            return View(homeBlog);
        }

        // POST: Admin/HomeBlogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,AuthorName,Date,Category,Text")] HomeBlog homeBlog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homeBlog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homeBlog);
        }

        // GET: Admin/HomeBlogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeBlog homeBlog = db.HomeBlogs.Find(id);
            if (homeBlog == null)
            {
                return HttpNotFound();
            }
            return View(homeBlog);
        }

        // POST: Admin/HomeBlogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeBlog homeBlog = db.HomeBlogs.Find(id);
            db.HomeBlogs.Remove(homeBlog);
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
