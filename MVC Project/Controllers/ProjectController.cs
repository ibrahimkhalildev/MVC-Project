using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Earthwork()
        {
            return View();
        }
        public ActionResult Bridge()
        {
            return View();
        }
        public ActionResult Canal()
        {
            return View();
        }
        public ActionResult Embankment()
        {
            return View();
        }
        public ActionResult Road()
        {
            return View();
        }

    }
}