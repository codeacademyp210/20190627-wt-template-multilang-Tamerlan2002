using Chimper.DAL;
using Chimper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chimper.Controllers
{
    public class ServicesController : Controller
    {
        ChimperContext db = new ChimperContext();
        // GET: Services
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.ServicesRespss = db.ServicesResps.ToList();
            model.ServicesUpperss = db.ServicesUppers.ToList();
            model.Testimonialss = db.Testimonials.ToList();
            return View(model);
        }
    }
}