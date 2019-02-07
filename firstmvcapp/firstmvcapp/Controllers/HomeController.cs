using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstmvcapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: AboutUs
        public ActionResult AboutUs()
        {
            return View();
        }

        //GET: AboutGame
        public ActionResult AboutGame()
        {
            return View();
        }
       
    }
}