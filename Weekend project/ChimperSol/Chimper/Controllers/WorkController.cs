using Chimper.DAL;
using Chimper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chimper.Controllers
{
    public class WorkController : Controller
    {
        ChimperContext db = new ChimperContext();
        // GET: Work
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Testimonialss = db.Testimonials.ToList();
            return View(model);
        }
    }
}