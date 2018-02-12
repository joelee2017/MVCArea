using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCArea.Areas.Accounting.Controllers
{
    public class HomeController : Controller
    {
        // GET: Accounting/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}