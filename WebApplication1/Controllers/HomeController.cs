using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
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

    }
}