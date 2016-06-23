using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _110213710301.Models
{
    public class OrderDetails : Controller
    {
        // GET: OrderDetails
        public ActionResult Index()
        {
            return View();
        }

        public int ProductId { get; set; }
    }
}