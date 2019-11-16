using MVCTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTraining.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeContext empCon = new EmployeeContext();
            Employee employee = empCon.Employees.Single(emp => emp.EmployeeID == id);
            return View(employee);
        }
    }
}