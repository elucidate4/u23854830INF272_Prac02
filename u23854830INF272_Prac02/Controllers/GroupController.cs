using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23854830INF272_Prac02.Models;

namespace u23854830INF272_Prac02.Controllers
{
    public class GroupController : Controller
    {
        
        public ActionResult Members()
        {
            List<GroupMemberDetails> memberDetails = new List<GroupMemberDetails>
            {   new GroupMemberDetails {Student_Number = "u23957281", FirstName = "Andani", Surname = "Bologo", Email = "u23957281@tuks.co.za", myLink = "~/HTML/Andani.html"},
                new GroupMemberDetails {Student_Number = "u23854830", FirstName = "Dakalo", Surname = "Nemamilwe", Email = "u23854830@tuks.co.za", myLink = "~/HTML/Dakalo.html"},
                new GroupMemberDetails {Student_Number = "u23643570", FirstName = "Mary", Surname = "Modiba", Email = "u23643570@tuks.co.za", myLink = "~/HTML/Mary.html"},
                new GroupMemberDetails {Student_Number = "u22715895", FirstName = "Moeletsi", Surname = "Melamu", Email = "u22715895@tuks.co.za", myLink = "~/HTML/Moeletsi.html"},
                new GroupMemberDetails {Student_Number = "u05084360", FirstName = "Zoe", Surname = "Joubert", Email = "u05084360@tuks.co.za", myLink = "~/HTML/Zoe.html"}
                
            };

            return View(memberDetails);
        }
    }
}