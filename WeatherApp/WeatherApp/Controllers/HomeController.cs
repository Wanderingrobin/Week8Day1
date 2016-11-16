using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Weather1
        public ActionResult Index()
        {
            return View("Weather2");
        }

        public JsonResult GetWeather()
        {
            WeatherClass myWeather = new WeatherClass();

            return Json(myWeather.GetCurrentWeather(), JsonRequestBehavior.AllowGet);
        }
    }
}