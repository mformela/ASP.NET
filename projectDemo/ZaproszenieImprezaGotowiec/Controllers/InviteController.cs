using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using ZaproszenieImprezaGotowiec.Models;

namespace ZaproszenieImprezaGotowiec.Controllers
{


    public class InviteController : Controller
    {
        //tutaj dodajemy dwie akcje - jedna z wymuszonym View, a druga z walidacją dla całego modelu 
        // GET: Invite
        public ActionResult Index()
        {
            return View("Index"); //jawna deklaracja widoku, zalecane 
        }

        public ActionResult InviteGuest(InviteModel model)
        {
            if (ModelState.IsValid) // sprawdza czy cały model się waliduje
            {
                SendEmail(model);
                return View("Thanks", model);
            }
            return View("Index", model);
        }



        //tworzymy metodę prywatną; z modelu pobierzemy mail klienta 
        private void SendEmail(InviteModel mailModel)
        {
            //konfigurujemy skrzynkę nadawczą |(możemy to ściągnąć z neta)
            var smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential("gym550182@gmail.com", "!QAZ2wsx#EDC")
            };


            // klient dostaje maila z podanego adresu, to: pobieramy maila z formularza
            //body: tutaj wpisujemy treść wiadomości 
            var mailMessage = new MailMessage
            {
                Sender = new MailAddress("gym550182@gmail.com"),
                From = new MailAddress("gym550182@gmail.com"),
                To = { mailModel.Email },
                Body = "Dziękujemy za wypełnienie formularza. Twoje zgłoszenie zostało przyjęte:)))",
                IsBodyHtml = true
            };


            //tutaj robimy taką zmianę, żeby wysyłało maile do obu osób - nadawcy i odbiorcy 
            //mailMessage.To.Add("mail osoby zapraszającej");
            //mailMessage.Body = "tresc dla";
            //SendEmail(mailMessage);
            //mailMessage.To.Clear();
            //mailMessage.To.Add("mail osoby zaproszonej");
            //mailMessage.Body = "treść dla osoby zaproszonej";
            //SendEmail(mailMessage);

            //if (ModelState.IsValid) // sprawdza czy cały model się waliduje
            //{
            //    SendEmail(model);
            //    return View("Thanks", model);
            //}
            //return View("Index", model);





            smtpClient.Send(mailMessage);
        }


    }


}