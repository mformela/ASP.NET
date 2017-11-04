using projectDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectDemo.Controllers
{
    public class BigLetterController : Controller
    {
        // GET: BigLetter
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index1(FirstBigLetter model)
        {
            return View("Index", model);
        }

    }
}