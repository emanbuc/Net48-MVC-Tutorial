using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication1.Controllers
{
    public class AnagraficaController : Controller
    {
        // GET: Anagrafica
        public ActionResult Index()
        {
            return View();
        }

        // GET: Anagrafica/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Anagrafica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anagrafica/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Anagrafica/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Anagrafica/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Anagrafica/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Anagrafica/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
