using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudyPortal.Models;

namespace StudyPortal.Controllers
{
    public class MvcController : Controller
    {
        private Dbentity db = new Dbentity();

        // GET: Mvc
        public ActionResult Index()
        {
            return View(db.Mvc.ToList());
        }

        // GET: Mvc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mvc mvc = db.Mvc.Find(id);
            if (mvc == null)
            {
                return HttpNotFound();
            }
            return View(mvc);
        }

        // GET: Mvc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mvc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MvcId,Question,OptionA,OptionB,OptionC,OptionD")] Mvc mvc)
        {
            if (ModelState.IsValid)
            {
                db.Mvc.Add(mvc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mvc);
        }

        // GET: Mvc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mvc mvc = db.Mvc.Find(id);
            if (mvc == null)
            {
                return HttpNotFound();
            }
            return View(mvc);
        }

        // POST: Mvc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MvcId,Question,OptionA,OptionB,OptionC,OptionD")] Mvc mvc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mvc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mvc);
        }

        // GET: Mvc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mvc mvc = db.Mvc.Find(id);
            if (mvc == null)
            {
                return HttpNotFound();
            }
            return View(mvc);
        }

        // POST: Mvc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mvc mvc = db.Mvc.Find(id);
            db.Mvc.Remove(mvc);
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
