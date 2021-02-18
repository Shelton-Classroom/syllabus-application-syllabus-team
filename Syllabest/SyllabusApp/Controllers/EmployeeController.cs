using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ITP_298;

namespace SyllabusApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeEntities db = new EmployeeEntities();
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.LoginFailed = null;
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username != null)
            {
                Employee employee = db.Employee.Find(username);
                Employee code = db.Employee.Find(password);
                // need to compare the input to the database and make sure that
                // the password matches for the username stored in the database
                // if so, display a welcome message for now
                //if not, display error message
            }
            else if (username == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            return View();
        }

        
            

      
        

    }
}