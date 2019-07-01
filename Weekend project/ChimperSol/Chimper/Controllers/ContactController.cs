using Chimper.DAL;
using Chimper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chimper.Controllers
{
    public class ContactController : Controller
    {
        ChimperContext db = new ChimperContext();
        // GET: Contact
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.ContactInfoss = db.ContactInfos.ToList();
            model.MoreInfoss = db.MoreInfos.ToList();
            return View(model);
        }
    }
}