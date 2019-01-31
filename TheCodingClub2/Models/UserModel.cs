using System;

namespace TheCodingClub2
{
    
    public class User
    {
        ///UserID, key for user table
        
        public int UserID {get;set;}

        ///FirstName of user
        public string fName {get;set;}

        ///Last name of user
        public string lName {get;set;}

        ///user name
        public string userName {get;set;}

        ///password
        public string passWord {get;set;}
    }
    #region "StudentUsers"
    public class Student : User 
    {
        public string studID {get; set;}
        public string classification {get; set;}
        public int yearsExp {get; set;}

    }
    public class TeamLead : Student
    {
        /// the team lead ID
        public string tlID {get; set;}
    }
    public class Manager : Student
    {
        //just need the student id, can only be one manager
    }
    #endregion
    #region "Faculty"
    public class Advisor : User
    {
        public string facultyID {get; set;}
        public string position {get; set;}
        public int tenure {get; set;}
    }
    #endregion
}