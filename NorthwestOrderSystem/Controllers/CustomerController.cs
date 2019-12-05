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

/*
 System.Data.Entity.ModelConfiguration.ModelValidationException
  HResult=0x80131500
  Message=One or more validation errors were detected during model generation:

NorthwestOrderSystem.DAL.TestSchedule: : EntityType 'TestSchedule' has no key defined. Define the key for this EntityType.
TestSchedules: EntityType: EntitySet 'TestSchedules' is based on type 'TestSchedule' that has no keys defined.

  Source=<Cannot evaluate the exception source>
  StackTrace:
<Cannot evaluate the exception stack trace>

     */
