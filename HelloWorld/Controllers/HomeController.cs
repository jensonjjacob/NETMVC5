using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //to survive between multiple requests for the user
            Session["MyTimeSession"] = DateTime.Now.ToString();
            //We need to use TempData since ViewBag does not pass or survive when moving from one action to another
            TempData["MyTimeTemp"] = DateTime.Now.ToString();
            //Pass data from Index action to GotoHome using ViewBag
            ViewBag.MyTime = DateTime.Now.ToString();
            //return View();
            return RedirectToAction("GotoHome", "Home");
        }


        public ActionResult GotoHome()
           
        {
            //return View("MyHomePage");  // if you make the .cshtml page name same as the Action name, then you don't need to use "MyHomePage" in View
            //ViewData["MyTime"] = DateTime.Now.ToString();
            ViewBag.MyTime = DateTime.Now.ToString(); // this will be set again otherwise 
            return View();
        }
    }
}