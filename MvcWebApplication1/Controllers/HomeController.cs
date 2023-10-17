using MvcWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Anagrafica()
        {
            AnagraficaModel m = new AnagraficaModel();
            //carica i dati e popola viewmodel 
            m.Nome = "Andrea";

            //passa viewmodel alla view per rendering
            return View(m);
        }

        public ActionResult ListaAnagrafica()
        {
            List<AnagraficaModel> list = new List<AnagraficaModel>();
            list.Add(new AnagraficaModel { Nome = "Nome1", Cognome= "Cognome1"});
            list.Add(new AnagraficaModel { Nome = "Nome2", Cognome = "Cognome2" });



            //passa viewmodel alla view per rendering
            return View("ViewList", list);
        }

    }
}