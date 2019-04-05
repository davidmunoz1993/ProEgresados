using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Egresados.Models;

namespace Egresados.Controllers
{
    public class AñadirpublicacionesController : Controller
    {
        private EgresadosContext db = new EgresadosContext();

        // GET: Añadirpublicaciones
        public ActionResult Index()
        {
            return View(db.Añadirpublicaciones.ToList());
        }

        // GET: Añadirpublicaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Añadirpublicaciones añadirpublicaciones = db.Añadirpublicaciones.Find(id);
            if (añadirpublicaciones == null)
            {
                return HttpNotFound();
            }
            return View(añadirpublicaciones);
        }

        // GET: Añadirpublicaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Añadirpublicaciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AñadirpublicacionesID,FechaInicio,FechaFinal,Asunto,Descripcion")] Añadirpublicaciones añadirpublicaciones)
        {
            if (ModelState.IsValid)
            {
                db.Añadirpublicaciones.Add(añadirpublicaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(añadirpublicaciones);
        }

        // GET: Añadirpublicaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Añadirpublicaciones añadirpublicaciones = db.Añadirpublicaciones.Find(id);
            if (añadirpublicaciones == null)
            {
                return HttpNotFound();
            }
            return View(añadirpublicaciones);
        }

        // POST: Añadirpublicaciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AñadirpublicacionesID,FechaInicio,FechaFinal,Asunto,Descripcion")] Añadirpublicaciones añadirpublicaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(añadirpublicaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(añadirpublicaciones);
        }

        // GET: Añadirpublicaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Añadirpublicaciones añadirpublicaciones = db.Añadirpublicaciones.Find(id);
            if (añadirpublicaciones == null)
            {
                return HttpNotFound();
            }
            return View(añadirpublicaciones);
        }

        // POST: Añadirpublicaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Añadirpublicaciones añadirpublicaciones = db.Añadirpublicaciones.Find(id);
            db.Añadirpublicaciones.Remove(añadirpublicaciones);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
