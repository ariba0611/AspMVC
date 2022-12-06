using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Railway.Models;
using Railway.Models.DAL;

namespace Railway.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Reservation> interfaceObj;
        public HomeController() { 
        this.interfaceObj = new Repository<Reservation>();
        
        }
        // GET: Home
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Reservation res)
        {
            interfaceObj.InsertModel(res);
            interfaceObj.Save();
            //return RedirectToAction("Index")
            return View();
        }
    }
}