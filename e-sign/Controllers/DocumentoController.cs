using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using e_sign.Models;

namespace e_sign.Controllers
{
    public class DocumentoController : Controller
    {
        private FirmasElectronicasEntities1 db = new FirmasElectronicasEntities1();

        // GET: Documento
        public ActionResult Index()
        {
            var documento = db.Documento.Include(d => d.Token1).Include(d => d.Usuario1);
            return View(documento.ToList());
        }

        // GET: Documento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Documento documento = db.Documento.Find(id);
            if (documento == null)
            {
                return HttpNotFound();
            }
            return View(documento);
        }

        // GET: Documento/Create
        public ActionResult Create()
        {
            ViewBag.Token = new SelectList(db.Token, "Id", "Token1");
            ViewBag.Usuario = new SelectList(db.Usuario, "Id", "Rut");
            return View();
        }

        // POST: Documento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Token,Usuario,Nombre,Validador,Estado,Extension,C_Log,Creacion,Modificacion")] Documento documento)
        {
            if (ModelState.IsValid)
            {
                db.Documento.Add(documento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Token = new SelectList(db.Token, "Id", "Token1", documento.Token);
            ViewBag.Usuario = new SelectList(db.Usuario, "Id", "Rut", documento.Usuario);
            return View(documento);
        }

        // GET: Documento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Documento documento = db.Documento.Find(id);
            if (documento == null)
            {
                return HttpNotFound();
            }
            ViewBag.Token = new SelectList(db.Token, "Id", "Token1", documento.Token);
            ViewBag.Usuario = new SelectList(db.Usuario, "Id", "Rut", documento.Usuario);
            return View(documento);
        }

        // POST: Documento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Token,Usuario,Nombre,Validador,Estado,Extension,C_Log,Creacion,Modificacion")] Documento documento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(documento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Token = new SelectList(db.Token, "Id", "Token1", documento.Token);
            ViewBag.Usuario = new SelectList(db.Usuario, "Id", "Rut", documento.Usuario);
            return View(documento);
        }

        // GET: Documento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Documento documento = db.Documento.Find(id);
            if (documento == null)
            {
                return HttpNotFound();
            }
            return View(documento);
        }

        // POST: Documento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Documento documento = db.Documento.Find(id);
            db.Documento.Remove(documento);
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
