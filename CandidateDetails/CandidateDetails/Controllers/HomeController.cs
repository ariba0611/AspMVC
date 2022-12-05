using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandidateDetails.Models;

namespace CandidateDetails.Controllers
{
    public class HomeController : Controller
    {
        CandidateContext db = new CandidateContext();
       
        public ActionResult Index()
        {
            var data = db.candidates;
            return View(data);
        }

        public ActionResult Create() { 
        
        return View();  
        }

        [HttpPost]
        public ActionResult Create(Candidate cs)
        {
            try
            {
                SqlParameter param1 = new SqlParameter("@CandidateID", cs.CandidateID);
                SqlParameter para2 = new SqlParameter("@CandidateName", cs.CandidateName);
                SqlParameter para3 = new SqlParameter("@CandidateAddress", cs.CandidateAddress);
                SqlParameter para4 = new SqlParameter("@CandidatePhone", cs.CandidatePhone);
                SqlParameter para5 = new SqlParameter("@CandidatQualification", cs.CandidatQualification);

                db.Database.SqlQuery<Candidate>("exec InsValues @CandidateID, @CandidateName, @CandidateAddress, @CandidatePhone, @CandidatQualification ", param1, para2, para3, para4, para5).ToList<Candidate>().SingleOrDefault();

              


                
            }
            catch (Exception ex) { 
            
            Console.WriteLine(ex.Message);
            }
            ModelState.Clear();
            return View();
            /*db.candidates.SqlQuery("InsValues",cs);
            

            ModelState.Clear();

            return View();*/
        }
    }
}