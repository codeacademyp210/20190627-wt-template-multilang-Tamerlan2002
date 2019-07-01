using Chimper.DAL;
using Chimper.Models;
using MultiLanMVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chimper.Controllers
{
    public class HomeController : MyController
    {
        ChimperContext db = new ChimperContext();
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.CompanyFeaturess = db.CompanyFeatures.ToList();
            model.HomeCharachess = db.HomeCharaches.ToList();
            model.HomeBlogss = db.HomeBlogs.ToList();
            model.HomeProjectss = db.HomeProjects.ToList();
            model.Testimonialss = db.Testimonials.ToList();
            return View(model);
        }
        public ActionResult ChangeLanguage(string lang)
        {
            new LanguageMang().SetLanguage(lang);
            return RedirectToAction("Index", "Home");
        }

    }
}