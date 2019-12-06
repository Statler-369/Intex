using NorthwestOrderSystem.DAL;
using NorthwestOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/* Project Northwest Labs Order System
 * Version 1.0
 * Prototype created by Statler Smith, Tanner Hunt, Ashton Greenburg, and Miles Johnson
 * 
 * The purpose of the order system is detailed below.
 * 
 * The system will assist the following three categories of people:
 * General:
 *      - Enable general public to view a basic catalog of assays, along with pricing
 *      - Enable general public to submit company information for an order
 * Customers:
 *      - Enable existing customers to view their order history
 *      - Enable existing customers to view their order status
 *      - Enable existing customers to view test results electronically
 * Employees:
 *      - Enable Employees to record and maintain work order information
 *      - Enable Employees to track the testing schedule
 *      - Enable Employees to store test results in original format
 *      - Enable Employees to store summary data
 *      - Enable Employees to obtain necessary information for Customer Support
 *      - Enable Employees to update billing and pricing information
 *      - Support sales activities with performance and other reports 
 *      - Enable Employees to update catalogs
 * 
 * An additional purpose for this system is to facilitate communication between the Singapore and Seattle offices.
 * 
 * This prototype, while not yet fully functional, demonstrates the ability of this team to provide the full system.
 * December 12, 2019
*/

namespace NorthwestOrderSystem.Controllers
{
    public class HomeController : Controller
    {
        /*
         *  This controller links to the general pages.
         *  These pages include the home page, about page, contact page, and login page.
         * 
         * The home page contains some basic information about the company.
         * 
         * The about page contains a list of the assays along with the base price.
         * 
         * The contact page provides a form for a company to input their information. 
         *      This form will add the company's information into the database.
         * 
         * The login page allows either a company representative or Northwest Lab employee to login.
         * 
        */

        private IntexTestContext db = new IntexTestContext();    
        // GET: Home
        public ActionResult Index()
        {
            //This method will bring up the Home Page. This is the first page seen.
            return View();
        }

        public ActionResult Login()
        {
            /*
             * This method will bring up the login page. 
             * The login page provides a form for a user to enter their credentials.
             * */
            ViewBag.Validation = "";
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            /*
             * This method takes the information from the login form and checks for authentication.
             * Since this website is currently a prototype, full authentication is not yet implemented.
             * For now, we have hardcoded all of the possible usernames.
             *      Only "Customer" and "Employee" are currently useful.
             * 
             * */
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
            /*
             * 
             * */
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