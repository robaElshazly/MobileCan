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
            return View();
        }

        public ActionResult About()
        {
           var info= db.CompanyInfoes.FirstOrDefault();

            return View(info);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}