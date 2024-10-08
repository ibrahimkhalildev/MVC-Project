using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class FindController : Controller
    {
        // GET: Find
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Employee()
        {
            return View();
        }
        public ActionResult Staff()
        {
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }
    }
}