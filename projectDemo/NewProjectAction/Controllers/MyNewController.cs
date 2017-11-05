using NewProjectAction.BusinessLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewProjectAction.Controllers
{
    public class MyNewController : Controller
    {
        // deklarujemy prywatne pole 
        private FileBusinessLogic _fileBusinessLogic;


        //tutaj tworzymy konstruktor, tworzymy nowy obiekt klasy w momencie inicjalizacji kontrolera, tworzona jest instancja 
        public MyNewController()
        {
            _fileBusinessLogic = new FileBusinessLogic();
        }






        // GET: MyNew
        public ActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase photo)
        {

            if (photo != null)
            {
                ViewBag.Dane = "Nazwa to " + Path.GetFileName(photo.FileName) + " rozmiar to: " + photo.ContentLength + " rozszerzenie: " + Path.GetExtension(photo.FileName);

                //tutaj mamy metodę, która sprawdza długość nazwy pliku 
                //if (Path.GetFileName(photo.FileName).Length <= 9)
                //{
                //    ViewBag.Message = " plik jest ok";

                //}
                //else
                //{
                //    ViewBag.Message = " nazwa pliku jest za długa!!";
                //}

                //tutaj odnosimy się do logiki biznesowej (powyżej) , którą wynieśliśmy do innej klasy, to robi porządek w kodzie. 
                if (_fileBusinessLogic.CheckFileName(Path.GetFileName(photo.FileName))) ;
            }
            return View();


            

        }

    }           

}               
