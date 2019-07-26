using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Padaria_Rick.Data;
using Padaria_Rick.Models.Entity;

namespace Padaria_Rick.Controllers
{
    public class PromocaosController : Controller
    {
        private PadariaContext db = new PadariaContext();

        // GET: Promocaos
        public ActionResult Index()
        {
            return View(db.Promocoe.ToList());
        }

        // GET: Promocaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promocao promocao = db.Promocoe.Find(id);
            if (promocao == null)
            {
                return HttpNotFound();
            }
            return View(promocao);
        }

        // GET: Promocaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Promocaos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Valor")] Promocao promocao)
        {
            if (ModelState.IsValid)
            {
                db.Promocoe.Add(promocao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(promocao);
        }

        // GET: Promocaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promocao promocao = db.Promocoe.Find(id);
            if (promocao == null)
            {
                return HttpNotFound();
            }
            return View(promocao);
        }

        // POST: Promocaos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Valor")] Promocao promocao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(promocao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(promocao);
        }

        // GET: Promocaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promocao promocao = db.Promocoe.Find(id);
            if (promocao == null)
            {
                return HttpNotFound();
            }
            return View(promocao);
        }

        // POST: Promocaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Promocao promocao = db.Promocoe.Find(id);
            db.Promocoe.Remove(promocao);
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
