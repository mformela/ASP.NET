using BMI.BL;
using BMI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BMI.Controllers
{
    public class BMIController : Controller
    {
        // deklarujemy prywatne pole 
        private BMICalculator _bmiCalculator;


        //tutaj tworzymy konstruktor, tworzymy nowy obiekt klasy w momencie inicjalizacji kontrolera, tworzona jest instancja 
        public BMIController()
        {
            _bmiCalculator = new BMICalculator();
        }



        // GET: BMI
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Oblicz(PersonBMI model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Dane = "Twoje BMI to:" + _bmiCalculator;
                var bmi = _bmiCalculator.CalculateBMI(model.masa, model.wzrost);
                if (bmi> 25)
                {
                    ViewBag.Message = " Masz nadwagę, musisz schudnąć";
                        }
                else if  (bmi < 19)
                {
                    ViewBag.Message = " Masz niedowagę, musisz przytyć";
                }
                else
                {
                    ViewBag.Message = "Twoja waga jest prawidłowa";
                }
            }

           
            return View("Index", model);
        }

       
    }
}