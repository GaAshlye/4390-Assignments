using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace TheCodingClub2
{
    
    public class Projects
    {
        ///projID, key for proj table
        [Key]
        public int ProjectID {get;set;}

        ///project name
        public string PName {get;set;}

        ///due date
        public DateTime dd {get;set;}

        ///user companyname
        public string compname {get;set;}

        ///password
        public string teamLead {get;set;} //ideally from user class but for simplicity
        
    }
}