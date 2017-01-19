using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudyPortal.Models;
using PagedList;
namespace StudyPortal.Controllers
{
    public class CController : Controller
    {
        private Dbentity db = new Dbentity();

        // GET: C
        public ActionResult Index()
        {
            return View(db.DbC.ToList());
        }

        public ActionResult Introduction(int page = 1)
        {

            return View(db.DbC.OrderBy(x => x.CId).ToPagedList(page, 3));
        }

        // GET: C/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C c = db.DbC.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }

        // GET: C/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: C/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CId,Question,OptionA,OptionB,OptionC,OptionD,Answer,category")] C c)
        {
            if (ModelState.IsValid)
            {
                db.DbC.Add(c);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(c);
        }

        // GET: C/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C c = db.DbC.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }

        // POST: C/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CId,Question,OptionA,OptionB,OptionC,OptionD,Answer,category")] C c)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c);
        }

        // GET: C/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C c = db.DbC.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }

        // POST: C/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            C c = db.DbC.Find(id);
            db.DbC.Remove(c);
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
