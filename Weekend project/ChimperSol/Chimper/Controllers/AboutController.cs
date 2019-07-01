using Chimper.DAL;
using Chimper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chimper.Controllers
{
    public class AboutController : Controller
    {
        ChimperContext db = new ChimperContext();
        // GET: About
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();

            model.Specialitiess = db.Specialities.ToList();
            model.AboutSayingss = db.AboutSayings.ToList();
            model.Testimonialss = db.Testimonials.ToList();
            return View(model);
        }
    }
}