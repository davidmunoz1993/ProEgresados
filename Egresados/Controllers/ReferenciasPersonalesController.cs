﻿using System;
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
    public class ReferenciasPersonalesController : Controller
    {
        private EgresadosContext db = new EgresadosContext();

        // GET: ReferenciasPersonales
        public ActionResult Index()
        {
            return View(db.ReferenciasPersonales.ToList());
        }

        // GET: ReferenciasPersonales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasPersonales referenciasPersonales = db.ReferenciasPersonales.Find(id);
            if (referenciasPersonales == null)
            {
                return HttpNotFound();
            }
            return View(referenciasPersonales);
        }

        // GET: ReferenciasPersonales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferenciasPersonales/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "referenciasPersonalesID,NombresReferencia,PrimerApellidoReferencia,SegundoApellidoReferencia,CargoReferencia,TelefonoFijoReferencia,ExtTelefonoReferencia,TelefonoMovilReferencia")] ReferenciasPersonales referenciasPersonales)
        {
            if (ModelState.IsValid)
            {
                db.ReferenciasPersonales.Add(referenciasPersonales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referenciasPersonales);
        }

        // GET: ReferenciasPersonales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasPersonales referenciasPersonales = db.ReferenciasPersonales.Find(id);
            if (referenciasPersonales == null)
            {
                return HttpNotFound();
            }
            return View(referenciasPersonales);
        }

        // POST: ReferenciasPersonales/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "referenciasPersonalesID,NombresReferencia,PrimerApellidoReferencia,SegundoApellidoReferencia,CargoReferencia,TelefonoFijoReferencia,ExtTelefonoReferencia,TelefonoMovilReferencia")] ReferenciasPersonales referenciasPersonales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referenciasPersonales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referenciasPersonales);
        }

        // GET: ReferenciasPersonales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasPersonales referenciasPersonales = db.ReferenciasPersonales.Find(id);
            if (referenciasPersonales == null)
            {
                return HttpNotFound();
            }
            return View(referenciasPersonales);
        }

        // POST: ReferenciasPersonales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferenciasPersonales referenciasPersonales = db.ReferenciasPersonales.Find(id);
            db.ReferenciasPersonales.Remove(referenciasPersonales);
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
