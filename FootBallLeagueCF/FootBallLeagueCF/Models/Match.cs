using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FootBallLeagueCF.Models
{
    public class Match
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
  
        public int MatchID { get; set; }

        public string TeamName1 { get; set; }

        public string TeamName2 { get; set; }
  
        public string Status { get; set; }

        public string WinningTeam { get; set; }

    }
}