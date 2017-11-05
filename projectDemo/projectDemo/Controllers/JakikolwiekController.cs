using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectDemo.Controllers
{
    public class JakikolwiekController : Controller
    {
        // GET: Jakikolwiek

        [Route("Piesek")]
        public ActionResult pies()
        {
            return View();
        }

        [Route("Kicia")]
        public ActionResult kot()
        {
            return View();
        }

        [Route("Myszka")]
        public ActionResult mysz()
        {
            return View();
        }



    }
}