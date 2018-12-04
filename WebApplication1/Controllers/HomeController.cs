using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TOOP.Helpers;
using TOOP.Models;

namespace TOOP.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        private InsuranceContext insuranceContext = new InsuranceContext();

        public ActionResult Index()
        {
            IEnumerable<Insurance> insurances = insuranceContext.Insurances;

            return View(insurances);
        }

        public ActionResult Details(int id)
        {
            Insurance insurance = insuranceContext.Insurances.First(v => v.Id == id);

            return View(insurance);
        }

        [HttpGet]
        public ActionResult Order(int id)
        {
            Insurance insurance = insuranceContext.Insurances.First(v => v.Id == id);

            return View(new OrderViewModel() { Insurance = insurance });
        }

        [HttpPost]
        public ActionResult Order(Order o)
        {
            Order order = insuranceContext.Orders.Add(o);
            insuranceContext.SaveChanges();

            return View("OrderComplete", order);
        }

        public ActionResult SetCulture(string culture)
        {
            System.Diagnostics.Debug.WriteLine("Culture: " + culture);
            culture = CultureHelper.GetImplementedCulture(culture);

            HttpCookie cookie = Request.Cookies["_culture"];
            if (cookie != null)
                cookie.Value = culture;
            else
            {
                cookie = new HttpCookie("_culture");
                cookie.Value = culture;
                cookie.Expires = DateTime.Now.AddYears(1);
            }
            Response.Cookies.Add(cookie);

            return RedirectToAction("Index");
        }

    }
}