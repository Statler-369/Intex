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
            return View();
        }

        public ActionResult ListWorkOrders()
        {

            return View(db.SalesOrders.ToList());
        }

        
        public ActionResult Create()
        {
            ViewBag.Statuses = db.OrderStatuses.ToList();
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderStatusID,CompanyID,OrderComments,Expedite,DiscountID,TotalPrice,QuotedPrice,OrderDueDate")] SalesOrder salesOrder)
        {
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
            ViewBag.Statuses = db.OrderStatuses.ToList();
            return View(db.SalesOrders.Find(orderID));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssayID,ShortDesc,Cost,BasePrice,DetailedDesc")] SalesOrder salesOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ListWorkOrders");
            }
            return View(salesOrder);
        }
    }
}