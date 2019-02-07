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
        public ActionResult Index(int? category)
        {
            var viewModel = new HomeViewModel();
            viewModel.Categories = db.Categories;

            var filteredProducts = from product in db.Products.Include("Images")
                                   where !category.HasValue || product.CategoryId == category.Value
                                   select product;

            viewModel.Products = filteredProducts
                .ToList()
                .Select(p=>ProductViewModel.Map(p));

            return View(viewModel);
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