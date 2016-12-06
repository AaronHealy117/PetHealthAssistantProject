using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetHealthAssistantProject.DAL;
using PetHealthAssistantProject.Models;

namespace PetHealthAssistantProject.Controllers
{
    public class WalkController : Controller
    {
        private PetContext db = new PetContext();

        // GET: Walk
        public ActionResult Index()
        {
            return View(db.Walks.ToList());
        }

        // GET: Walk/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Walks walks = db.Walks.Find(id);
            if (walks == null)
            {
                return HttpNotFound();
            }
            return View(walks);
        }

        // GET: Walk/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Walk/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WalksID,WalksPark,WalksAddress")] Walks walks)
        {
            if (ModelState.IsValid)
            {
                db.Walks.Add(walks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(walks);
        }

        // GET: Walk/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Walks walks = db.Walks.Find(id);
            if (walks == null)
            {
                return HttpNotFound();
            }
            return View(walks);
        }

        // POST: Walk/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WalksID,WalksPark,WalksAddress")] Walks walks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(walks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(walks);
        }

        // GET: Walk/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Walks walks = db.Walks.Find(id);
            if (walks == null)
            {
                return HttpNotFound();
            }
            return View(walks);
        }

        // POST: Walk/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Walks walks = db.Walks.Find(id);
            db.Walks.Remove(walks);
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
