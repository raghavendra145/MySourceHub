using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject_Raghavendra.Models; 


namespace MVCProject_Raghavendra.Controllers
{

    public class EmployeeController : Controller
    {
        //  GET: Employee
        public ActionResult EmployeeInfo()
        //public string Employee = " ";
            
            
        {

            Employee employee = new Employee ()
            {
                EmployeeId = 217958,
                EmployeeName = "Raghavendra",
                EmployeeLocation = "Bangalore"
            };

            return View(employee);
        }
    }
}