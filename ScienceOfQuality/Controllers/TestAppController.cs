using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScienceOfQuality.Controllers
{
    public class TestAppController : Controller
    {
        // GET: TestApp
        public ActionResult CreateTicket()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}