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
            //We also want to show the order status
            List<SalesOrder> salesOrderList = db.SalesOrders.ToList();
            List<OrderHistory> orderHistoryList = new List<OrderHistory>();

            foreach(SalesOrder order in salesOrderList)
            {
                orderHistoryList.Add(new OrderHistory
                {
                    salesOrder = order,
                    orderStatus = db.Database.SqlQuery<string>("SELECT StatusDesc FROM OrderStatus WHERE OrderStatusID = " + order.OrderStatusID.ToString()).First()
                });

            }
            return View(orderHistoryList);
        }


        public ActionResult Details(int orderID)
        {
            orderID.ToString();
            List<OrderDetails> orderDetailsList = db.Database.SqlQuery<OrderDetails>("SELECT * FROM OrderDetails WHERE OrderID =" + orderID ).ToList();
            
            return View(orderDetailsList);
        }
    }
}