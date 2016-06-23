using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web;
using System.Web.Mvc;

namespace _110213710301.Models
{
    public class Order : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            var ods = new List<Models.OrderDetails>();
            ods.Add(new OrderDetails() { ProductId = 58 });
            this.OrderDetails = ods;
            return View();
        }

        /// <summary>
        /// 員工編號
        /// </summary>
        [DisplayName("員工編號")]
        [Required()]
        public int EmployeeID { get; set; }

        /// <summary>
        /// 員工姓名
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 員工職稱
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 任職日期
        /// </summary>
        /// 
        [DisplayName("任職日期")]
        public DateTime? HireDate { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }
    }
}