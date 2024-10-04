using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class BranchController : Controller
    {
        // GET: Branch
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dhaka()
        {
            return View();
        }
        public ActionResult Chattogram()
        {
            return View();
        }
        public ActionResult Khulna()
        {
            return View();
        }
        public ActionResult Rajshahi()
        {
            return View();
        }
    }
}