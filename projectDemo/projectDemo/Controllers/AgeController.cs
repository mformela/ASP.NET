using projectDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectDemo.Controllers
{
    public class AgeController : Controller
    {
        // GET: Age
        public ActionResult Index()
        {
  
            return View();
        }

        public ActionResult Index1(Age18 model)
        {
            return View("Index", model);
        }
    }
}