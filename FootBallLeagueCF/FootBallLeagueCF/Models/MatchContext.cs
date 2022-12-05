using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FootBallLeagueCF.Models
{
    public class MatchContext : DbContext
    {
        public DbSet<Match> Matches { get; set;}
    }
}