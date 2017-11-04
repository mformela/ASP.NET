using projectDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectDemo.Controllers
{
    public class ZipController : Controller
    {
        // GET: Zip
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index1 (ZipCode model)
        {
            return View("Index", model);
        }
    }
}