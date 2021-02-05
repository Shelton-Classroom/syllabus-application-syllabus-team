using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SyllabusApp.Models;
using System.Data.SqlClient;

namespace SyllabusApp.Controllers
{
    public class EmployeeController : Controller
    {
        SqlConnection con = new SqlConnection();    //this connects our commands to our database
        SqlCommand com = new SqlCommand();
        SqlDataReader sdr;  //this class reads the data 

        // GET: Account
        [HttpGet]
        public ActionResult Login() //began to create a login method, need to add a view for it
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "data source = dotnet.reynolds.edu; database = ITP298-Syllabus; integrated security =SSPI;";
            //this retrieves the database name and other parameters to initiate the connection 
        }
        public ActionResult Verify(Employee emp) //began a method to verify the login information
        {
            connectionString();
            con.Open(); //opens the database connection
            com.Connection = con; //returns the connection
            com.CommandText = "Select * from dbo.Employee where username='"+emp.Username+"' and password ='"+emp.Password+"'";
            sdr = com.ExecuteReader();

            if(sdr.Read())  //sends it to the next row if false
            {
                con.Close();
                return View();

            }
            else
            {
                con.Close();
                return View();
            }
            
        }
    }
}