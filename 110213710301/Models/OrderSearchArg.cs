using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _110213710301.Models
{
    public class OrderSearchArg : Controller
    {
        public string Title { get; set; }
        public string HireDate { get; set; }
        public string LastName { get; set; }
        public string EmployeeID { get; set; }
        
    }
}