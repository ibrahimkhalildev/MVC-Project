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
        public ActionResult Employee()
        {
            return View();
        }
    }
}