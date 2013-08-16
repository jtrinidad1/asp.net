using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingPS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "All about batter, butter, and maple syrup.";

            return View();
        }

        public ActionResult About()
        {
            
          return View();
        }

        public ActionResult getEmailAddress()
        {
            //String ea;
            
            //ea = usrform1;
            //Convert.
            return View(About());
        }
    }
}
