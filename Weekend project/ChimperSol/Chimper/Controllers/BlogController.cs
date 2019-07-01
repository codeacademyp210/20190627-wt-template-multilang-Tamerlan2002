using Chimper.DAL;
using Chimper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chimper.Controllers
{
    public class BlogController : Controller
    {
        ChimperContext db = new ChimperContext();
        // GET: Blog
        public ActionResult Index()
        {

            HomeViewModel model = new HomeViewModel();
            model.RealBogss = db.RealBogs.ToList();
            model.PopularPostss = db.PopularPosts.ToList();
            return View(model);
        }
    }
}