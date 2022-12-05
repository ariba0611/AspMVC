using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CandidateDetails.Models
{
    public class Candidate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int CandidateID { get; set; }
        public string CandidateName { get; set; }  
        
        public string CandidateAddress { get; set;}

        public int CandidatePhone { get; set; }
        public string CandidatQualification { get; set;}
    }
}