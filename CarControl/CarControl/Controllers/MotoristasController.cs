﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarControl.Models;

namespace CarControl.Controllers
{
    public class MotoristasController : Controller
    {
        private MotoristaContext db = new MotoristaContext();

        // GET: Motoristas
        public ActionResult Index()
        {
            return View(db.Motoristas.ToList());
        }

        // GET: Motoristas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorista motorista = db.Motoristas.Find(id);
            if (motorista == null)
            {
                return HttpNotFound();
            }
            return View(motorista);
        }

        // GET: Motoristas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motoristas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Rg,Cnh,Cpf,CategoriaCnh,Status,Email,ValidadeCnh,DataNasc,SeguroDeVida")] Motorista motorista)
        {
            if (ModelState.IsValid)
            {
                db.Motoristas.Add(motorista);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motorista);
        }

        // GET: Motoristas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorista motorista = db.Motoristas.Find(id);
            if (motorista == null)
            {
                return HttpNotFound();
            }
            return View(motorista);
        }

        // POST: Motoristas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Rg,Cnh,Cpf,CategoriaCnh,Status,Email,ValidadeCnh,DataNasc,SeguroDeVida")] Motorista motorista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motorista).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motorista);
        }

        // GET: Motoristas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorista motorista = db.Motoristas.Find(id);
            if (motorista == null)
            {
                return HttpNotFound();
            }
            return View(motorista);
        }

        // POST: Motoristas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Motorista motorista = db.Motoristas.Find(id);
            db.Motoristas.Remove(motorista);
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
