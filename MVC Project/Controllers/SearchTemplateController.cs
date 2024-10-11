using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class SearchTemplateController : Controller
    {
        // GET: SearchTemplate
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Teacher()
        {
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }
        public ActionResult BaseEmployee()
        {
            Employee obj = new Employee();
            obj.EmployeeName = "Ibrahim Khalil";
            obj.EmployeeCode = "EMP 001";

            return View(obj);
        }
        public ActionResult Search()
        {
            return View();
        }
    }
}
