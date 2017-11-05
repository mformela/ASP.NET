using Impreza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Impreza.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index1()
        {
            return View();
        }

        public ActionResult Index2(PartyMember model)
        {
            return View("Index1", model);
        }



    }
}