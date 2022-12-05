using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityAppMVC.Models;
using System.Data.Entity;
namespace UniversityAppMVC.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        public ActionResult Create() {
        
        return View();  
        
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
            ModelState.Clear();
            return View();

        }

        public ActionResult Edit(int id) {

            var row = db.Students.Where(model => model.StdId == id).FirstOrDefault();
            
            
            return View(row);
        
        
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {

           if(ModelState.IsValid == true) {
            
            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();

                ModelState.Clear();
            
            }
            
            return View();


        }

        public ActionResult Details(int id)
        {
            var row = db.Students.Where(model => model.StdId == id).FirstOrDefault();
            return View(row);  
        }

        public ActionResult Delete (int id) {
            
                var studentbyid = db.Students.Where(x => x.StdId == id).FirstOrDefault();
                if (studentbyid != null)
                {
                    db.Entry(studentbyid).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            
            return View(studentbyid);
        }
        [HttpPost]
        public ActionResult Delete(Student student)
        {
            return RedirectToAction("Index", "Home");   

        }
      
    }
}