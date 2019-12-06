using NorthwestOrderSystem.DAL;
using NorthwestOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestOrderSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private IntexTestContext db = new IntexTestContext();

        // GET: Employee
        public ActionResult Index()
        {
            /*The resulting view displays an employee portal. This portal provides links to perform common tasks.
             * Future versions of this page will provide different options for different employee positions.
             * */
            return View();
        }

        public ActionResult ListWorkOrders()
        {
            /*
             * The resulting view will list all of the sales orders for the employees to view.
             * Future versions will also provide a search or filter option.
             */
            return View(db.SalesOrders.ToList());
        }

        
        public ActionResult Create()
        {
            /*
             * The resulting view will allow employees to create a work order.
             * This will be done by employees in Singapore when they receive the mailed order.
             * Future versions will include creating an indicidual instance of the order details as well.
             */ 
            ViewBag.Statuses = db.OrderStatuses.ToList();
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderStatusID,CompanyID,OrderComments,Expedite,DiscountID,TotalPrice,QuotedPrice,OrderDueDate")] SalesOrder salesOrder)
        {
            //This method adds the order to the database.
            if (ModelState.IsValid)
            {
                db.SalesOrders.Add(salesOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salesOrder);
        }

        public ActionResult Edit(int orderID)
        {
            //This method allows for editing a current order based on the order id.
            ViewBag.Statuses = db.Database.SqlQuery<OrderStatus>("SELECT * FROM OrderStatus").ToList();
            return View(db.SalesOrders.Find(orderID));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderStatusID,CompanyID,OrderComments,Expedite,TotalPrice,QuotedPrice,OrderDueDate")] SalesOrder salesOrder)
        {
            //this method posts the edit to the database.
            if (ModelState.IsValid)
            {
                db.Entry(salesOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ListWorkOrders");
            }
            return View(salesOrder);
        }
        

        public ActionResult Schedule()
        {
            /*
             * This method will provide a view of all of the scheduled assay tests for the next week.
             * The view will only show the scheduled tests in the next 7 days.
             * The scheduling is still done by the manager who will input the scheduled test date via the website.
             */ 

            //This section takes the tests that are scheduled for the next 7 days and stores them in a list.
            List<OrderDetails> scheduledTests = db.Database.SqlQuery<OrderDetails>(
                "SELECT * " +
                "FROM OrderDetails " +
                "WHERE (DAY(ScheduledTestDate) BETWEEN DAY(GETDATE()) AND DAY(GETDATE()) + 7) " +
                "       AND(YEAR(ScheduledTestDate) = YEAR(GETDATE())) " +
                "       AND (MONTH(ScheduledTestDate) = MONTH(GETDATE()))" +
                "ORDER BY ScheduledTestDate").ToList();

            List<TestSchedule> testSchedule = new List<TestSchedule>();

            //This section adds the assay to be performed into the list of TestSchedule objects.
            foreach(OrderDetails order in scheduledTests)
            {
                testSchedule.Add(new TestSchedule
                {
                    orderDetails = order,
                    assay = db.Database.SqlQuery<Assay>("SELECT * FROM Assay WHERE AssayID =" + order.AssayID.ToString()).First()
                });
            }

            return View(testSchedule);
        }
    }
}