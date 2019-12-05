using NorthwestOrderSystem.DAL;
using NorthwestOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestOrderSystem.Controllers
{
    public class HomeController : Controller
    {
        /*This is the general info controller. ////////////////////////////////////////////
         * The home page contains login options. 
         * Customers will be directed to a set of views with customer stuff.
         * Employees will be directed to another set of views with employee stuff.
         *  Some employees will have access to part of the site, others will have access to the other part.
         * Without a login, people can still see what Northwest Labs is all about.
         * *///////////////////////////////////////////////////////////////////////////////

        private IntexTestContext db = new IntexTestContext();    
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Validation = "";
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if(username == "Customer")
            {                
                return RedirectToAction("Index", "Customer");
            }
            else if(username == "Employee")
            {
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                ViewBag.Validation = "Please enter valid username";
                return View();
            }            
        }

        public ActionResult About()
        {
            return View(db.Assays);
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyID,CompanyPassword,CompanyName,CompanyAddress,CompanyZip,CompanyCity,CompanyState,CompanyCountry")] Company company)
        {
            if (ModelState.IsValid)
            {
                db.Companies.Add(company);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(company);
        }
    }
}