using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ITP_298;

namespace Application.Controllers
{
    public class InstructorController : Controller
    {
        private Entities db = new Entities();

        // GET: Instructor
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.AspNetUser).ToList();
            employees = employees.Where(e=>e.EmployeeStatusId == (EmployeeStatusEnum.Instructor)).ToList();
            return View(employees.ToList());
        }

        // GET: Instructor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Instructor/Create
        public ActionResult Create()
        {
            ViewBag.LoginUserId = new SelectList(db.AspNetUsers, "Id", "Email");
            return View();
        }

        // POST: Instructor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeId,FirstName,LastName,EmployeeStatusId,PhoneNum,OfficeHours,LoginUserId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LoginUserId = new SelectList(db.AspNetUsers, "Id", "Email", employee.LoginUserId);
            return View(employee);
        }

        // GET: Instructor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoginUserId = new SelectList(db.AspNetUsers, "Id", "Email", employee.LoginUserId);
            return View(employee);
        }

        // POST: Instructor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeId,FirstName,LastName,EmployeeStatusId,PhoneNum,OfficeHours,LoginUserId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoginUserId = new SelectList(db.AspNetUsers, "Id", "Email", employee.LoginUserId);
            return View(employee);
        }

        // GET: Instructor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Instructor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult _IndexByName(string parm)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var employees = db.Employees.Include(e => e.AspNetUser).ToList();
            employees = employees.Where(e => e.EmployeeStatusId == (EmployeeStatusEnum.Instructor)).ToList();
            employees = employees.Where(e => e.Name.Contains(parm)).ToList();
            


            return PartialView("_Index", employees);
        }
    }
}
