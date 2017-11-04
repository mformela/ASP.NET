using projectDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectDemo.Controllers
{
    public class PoraDniaController : Controller
    {
        // GET: PoraDnia
        public ActionResult Index()
        {
            //ustawiamy wyświetlanie komunikatów w zależności od godziny 

            //int time = DateTime.Now.Hour;

            //if (time <= 17)
            //{
            //     ViewBag.Tresc = "Dzień dobry";
            //}
            //else
            //{
            //     ViewBag.Tresc = "Dobry wieczór";
            //}

            //return View();


            //odwołanie do modelu 

            var test = new PoraDniaClass();

            int time = DateTime.Now.Hour;

            if (time <= 17)
            {
                test.PoraDniaTest = "Dzień dobry";
            }
            else
            {
                test.PoraDniaTest = "Dobry wieczór";
            }
            return View(test);


        }
    }
}