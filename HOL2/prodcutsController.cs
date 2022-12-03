using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HOL1.Controllers
{
    public class prodcutsController : Controller
    {
        // GET: prodcuts
        public ActionResult Index()
        {
            Models.product p = new Models.product();
            return View(p.GetProducts());
        }
    }
}