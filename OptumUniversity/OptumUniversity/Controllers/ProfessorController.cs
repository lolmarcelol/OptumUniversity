using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OptumUniversity.DAL;
using OptumUniversity.Models;

namespace OptumUniversity.Controllers
{
    public class ProfessorController : Controller
    {
        private UniversityContext db = new UniversityContext();

        public JsonResult IndexJson()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return Json(db.Professores.ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index(string searchUser = "")
        {

            IEnumerable<Professor> result;

            if (!String.IsNullOrEmpty(searchUser))
            {
                result = (from m in db.Professores
                          where m.Turno.Contains(searchUser)
                          select m);

                if (result == null)
                {
                    ViewBag.Alerta = "Nenhum registro encontrado para " + searchUser;
                    var professoress = db.Professores.Include(p => p.Disciplina);
                    return View(professoress.ToList());
                }

            }
            else
            {
                result = (from m in db.Professores
                          select m).ToList();
            }


            var professores = db.Professores.Include(p => p.Disciplina);
            return View(result);
        }

        // GET: Professor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professor professor = db.Professores.Find(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        // GET: Professor/Create
        public ActionResult Create()
        {
            ViewBag.DisciplinaID = new SelectList(db.Disciplinas, "DisciplinaID", "Nome");
            return View();
        }

        // POST: Professor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProfessorID,Nome,Turno,DisciplinaID")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.Professores.Add(professor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DisciplinaID = new SelectList(db.Disciplinas, "DisciplinaID", "Nome", professor.DisciplinaID);
            return View(professor);
        }

        // GET: Professor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professor professor = db.Professores.Find(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            ViewBag.DisciplinaID = new SelectList(db.Disciplinas, "DisciplinaID", "Nome", professor.DisciplinaID);
            return View(professor);
        }

        // POST: Professor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProfessorID,Nome,Turno,DisciplinaID")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(professor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DisciplinaID = new SelectList(db.Disciplinas, "DisciplinaID", "Nome", professor.DisciplinaID);
            return View(professor);
        }

        // GET: Professor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professor professor = db.Professores.Find(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        // POST: Professor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Professor professor = db.Professores.Find(id);
            db.Professores.Remove(professor);
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