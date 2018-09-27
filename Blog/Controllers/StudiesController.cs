using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Blog;
using Blog.Models;

namespace Blog.Controllers
{
    public class StudiesController : Controller
    {
        private BlogContext db = new BlogContext();

        //GET: Studies
        public ActionResult Index()
        {
            return View(db.Studies.ToList());
        }

        //// GET: Studies/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Study study = db.Studies.Find(id);
        //    if (study == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(study);
        //}

        //// GET: Studies/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Studies/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Type,Title,BodyText,ReleaseTime")] Study study)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Studies.Add(study);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(study);
        //}

        //// GET: Studies/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Study study = db.Studies.Find(id);
        //    if (study == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(study);
        //}

        //// POST: Studies/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Type,Title,BodyText,ReleaseTime")] Study study)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(study).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(study);
        //}

        //// GET: Studies/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Study study = db.Studies.Find(id);
        //    if (study == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(study);
        //}

        //// POST: Studies/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Study study = db.Studies.Find(id);
        //    db.Studies.Remove(study);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
