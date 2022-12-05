using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CandidateDetails.Models
{
    public class CandidateContext : DbContext
    {
       public DbSet<Candidate> candidates { get; set; }


    }
}