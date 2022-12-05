using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QueryString.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id,string name)
        {
            ViewBag.Id = id;
            ViewBag.Name = name;
            return View();
        }
    }
}