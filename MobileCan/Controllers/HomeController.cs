using MobileCan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileCan.Controllers
{
    public class HomeController : Controller
    {
        MobileCanEntities db = new MobileCanEntities();
        public ActionResult Index()
        {
            return View(db.Categories);
        }

        public ActionResult About()
        {
           var info= db.CompanyInfoes.FirstOrDefault();

            return View(info);
        }
        [Authorize(Roles ="Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "You as admin you can see this page, others cannot";

            return View();
        }
    }
}