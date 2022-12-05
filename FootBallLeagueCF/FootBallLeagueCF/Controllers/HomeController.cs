using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootBallLeagueCF.Models;

namespace FootBallLeagueCF.Controllers
{
    public class HomeController : Controller
    {
        MatchContext db = new MatchContext();
        // GET: Home
        public ActionResult AddMatchResult()
        {
            return View();  

        }



        [HttpPost]
        public ActionResult AddMatchResult(Match match)
        {
           try
            {


                    SqlParameter param1 = new SqlParameter("@MatchID", match.MatchID);
                    SqlParameter para2 = new SqlParameter("@TeamName1", match.TeamName1);
                    SqlParameter para3 = new SqlParameter("@TeamName2", match.TeamName2);
                    SqlParameter para4 = new SqlParameter("@Status", match.Status);
                    SqlParameter para5 = new SqlParameter("@WinningTeam", match.WinningTeam);

                    db.Database.SqlQuery<Match>("exec Sp_InsertMatch @MatchID, @TeamName1, @TeamName2, @Status, @WinningTeam ", param1, para2, para3, para4, para5).ToList<Match>().SingleOrDefault();




                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        
            ModelState.Clear();
            return View();
        }
    }
}