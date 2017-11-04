using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectDemo.Controllers
{
    public class PiesekController : Controller
    {
        // GET: Piesek
        public ActionResult Index()
        {
            ViewBag.Message = "your application description page.";
            return View();

        }

        //albo dodajemy nowy view jako akcję (poniżej), albo zwracamy View("Kotek") i  wychodzi na to samo co mamy poniżej:
        public ActionResult Kotek()
        {
            ViewBag.Tresc = "tralalalala";
            return View();
        }


    }
}