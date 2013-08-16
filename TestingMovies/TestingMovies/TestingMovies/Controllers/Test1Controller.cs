using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingMovies.Controllers
{
    public class Test1Controller : Controller
    {
        //
        // GET: /Test1/
        /*
        public string Index()
        {
            //return View();
            return "This is the <b><i>default</b></i> action.";
        }
        */
        public ActionResult Index()
        {
            return View();
            //return "This is the <b><i>default</b></i> action.";
        }
        
        public string Welcome()
        {
            return "This is the Welcome action method.";
        }

        public ActionResult Nice(string m, int? counter)
        {
            if (m == null || m == "") { m = "Smitty"; }
            if (counter == null) { counter = 40; }
            //return "Yo Mama's name is " + m + " and she is like " + counter + " years old!";
            ViewBag.Message = "Your mother came by " + counter + " times today.  I said \"Hi, " + m + "!\"";
            ViewBag.counter = counter;

            return View();
        }
    }
}