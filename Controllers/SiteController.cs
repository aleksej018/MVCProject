using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekat.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UnosGraficka()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UnosGraficka(Models.Graficka proizvod)
        {
            return View("PrikazGraficka", proizvod);
        }


        [HttpGet]
        public ActionResult UnosProcesor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UnosProcesor(Models.Procesor proizvod)
        {
            return View("PrikazProcesor", proizvod);
        }
    }
}