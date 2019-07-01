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
    public class PopularPostsController : Controller
    {
        private ChimperContext db = new ChimperContext();

        // GET: Admin/PopularPosts
        public ActionResult Index()
        {
            return View(db.PopularPosts.ToList());
        }

        // GET: Admin/PopularPosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PopularPosts popularPosts = db.PopularPosts.Find(id);
            if (popularPosts == null)
            {
                return HttpNotFound();
            }
            return View(popularPosts);
        }

        // GET: Admin/PopularPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/PopularPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LinkText")] PopularPosts popularPosts)
        {
            if (ModelState.IsValid)
            {
                db.PopularPosts.Add(popularPosts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(popularPosts);
        }

        // GET: Admin/PopularPosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PopularPosts popularPosts = db.PopularPosts.Find(id);
            if (popularPosts == null)
            {
                return HttpNotFound();
            }
            return View(popularPosts);
        }

        // POST: Admin/PopularPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LinkText")] PopularPosts popularPosts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(popularPosts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(popularPosts);
        }

        // GET: Admin/PopularPosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PopularPosts popularPosts = db.PopularPosts.Find(id);
            if (popularPosts == null)
            {
                return HttpNotFound();
            }
            return View(popularPosts);
        }

        // POST: Admin/PopularPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PopularPosts popularPosts = db.PopularPosts.Find(id);
            db.PopularPosts.Remove(popularPosts);
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
