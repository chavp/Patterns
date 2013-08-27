using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChavpWeb.Models;

namespace ChavpWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(new IndexViewModel
            {
                UserName = "Chavp"
            });
        }

    }
}
