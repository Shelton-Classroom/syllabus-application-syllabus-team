using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SyllabusApp.Models;

namespace SyllabusApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login() //began to create a login method
        {
            return View();
        }
        public ActionResult Verify(Employee acc) //began a method to verify the login information,just need to populate our username/password in database
        {
            return View();
        }
    }
}