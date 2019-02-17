using MobileCan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace MobileCan.Controllers
{
    public class ProductController : Controller
    {
        MobileCanEntities db = new MobileCanEntities();

        // GET: Product
        public ActionResult Details(int Id)
        {
            var viewModel = new ProductViewModel();
            var product = (from p in db.Products.Include("Images")
                          where p.ProductId == Id
                          select p).Single();
            viewModel = ProductViewModel.Map(product);
            return View(viewModel);
        }
    }
}