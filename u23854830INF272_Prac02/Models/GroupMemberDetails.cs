using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u23854830INF272_Prac02.Models
{
    public class GroupMemberDetails
    {
        //unique number for each student
        [Display(Name = "Student Number")]
        public String Student_Number { get; set; }
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        [Display(Name = "Surname")]
        public String Surname { get; set; }
        [Display(Name = "Email Address")]
        public String Email { get; set; }

        [Display(Name = "Link to personal page")]
        public string myLink { get; set; }

        //add decorators to the properties
    }
}