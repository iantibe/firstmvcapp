using firstmvcapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace firstmvcapp.Controllers
{
    public class persondetailController : Controller
    {
        // GET: persondetail
        public ActionResult Index()
        {

            var model = new personmodel
            {
                Firstname = "Ian",
                Lastname = "Tibe",
                Genderlabel = shared.enums.genderenum.male,
                Age = 40,
                Major = "BIS"
            };
            return View(model);
        }
    }
}