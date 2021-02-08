using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITP_298;
using System.Data.SqlClient;

namespace SyllabusApp.Controllers
{
    public class EmployeeController : Controller
    {
       // SqlConnection con = new SqlConnection();    //this connects our commands to our database
       // SqlCommand com = new SqlCommand();
       // SqlDataReader sdr;  //this class reads the data 

        // GET: Account
        [HttpGet]
        public ActionResult Login() //began to create a login method, need to add a view for it
        {
            return View();
        }

        
            
    }
}