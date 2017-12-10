using Monitoreo.COMMON.Entidades;
using Monitoreo.COMMON.Interfaces;
using Monitoreo.DAL.NoSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monitoreo.UI.WebBackend.Views
{
    public class LecturaController : Controller
    {
        IGenericRepository<Lectura> LecturaRepositorio;
        // GET: Lectura
        public LecturaController()
        {
            LecturaRepositorio = new GenericRepository<Lectura>("Lecutras");
        }

        public ActionResult Index()
        {
            return View(LecturaRepositorio.Read.AsEnumerable());
        }

        // GET: Lectura/Details/5
        public ActionResult Details(string id)
        {
            return View(LecturaRepositorio.Read.Where(l=>l.ID==id).SingleOrDefault());
            //select top 1 * from lectura where ID='id'
        }

        // GET: Lectura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lectura/Create
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

        // GET: Lectura/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lectura/Edit/5
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

        // GET: Lectura/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lectura/Delete/5
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
