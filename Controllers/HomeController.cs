using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalPropertyAnalysisMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var repo = new OfferRepository();
            var offers = repo.GetAllOffers();
            return View(offers);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}