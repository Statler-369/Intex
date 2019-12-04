using NorthwestOrderSystem.DAL;
using NorthwestOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestOrderSystem.Controllers
{
    public class CustomerController : Controller
    {
        private IntexTestContext db = new IntexTestContext();

        // GET: Customer
        public ActionResult Index()
        {
            //This view will show them their order history            

            return View(db.SalesOrders.ToList());
        }


        public ActionResult Details(int orderID)
        {
            orderID.ToString();
            List<OrderDetails> orderDetailsList = db.Database.SqlQuery<OrderDetails>("SELECT * FROM OrderDetails WHERE OrderID =" + orderID ).ToList();
            return View(orderDetailsList);
        }
    }
}