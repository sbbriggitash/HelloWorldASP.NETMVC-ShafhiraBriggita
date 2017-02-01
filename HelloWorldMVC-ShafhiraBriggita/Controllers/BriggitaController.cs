using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC_ShafhiraBriggita.Controllers
{
    public class BriggitaController : Controller
    {
        // GET: Briggita
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Anything()
        {
            return Content("Hello Shafhira! Welcome to MVC!");
        }
        public ActionResult Something()
        {
            return Content("Say something you want to say...");
        }
        public ActionResult ShowSomething()
        {
            return View();
        }

    }
}