using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcBasic_clone.Models;

namespace MvcBasic_clone.Controllers
{
    public class FormController : Controller
    {
        private InfoContext db = new InfoContext();

        // GET: Form
        public ActionResult Index()
        {
            return View(db.Info.ToList());
        }

        public ActionResult UserInfo()
        {
            var  info = db.Info.ToList();

            return View(info);
        }

        // GET: Form/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Info info = db.Info.Find(id);
            if (info == null)
            {
                return HttpNotFound();
            }
            return View(info);
        }

        // GET: Form/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Form/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Phone,Email,Gender")] Info info)
        {
            if (ModelState.IsValid)
            {
                db.Info.Add(info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(info);
        }

        // GET: Form/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Info info = db.Info.Find(id);
            if (info == null)
            {
                return HttpNotFound();
            }
            return View(info);
        }

        // POST: Form/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Phone,Email,Gender")] Info info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(info).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(info);
        }

        // GET: Form/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Info info = db.Info.Find(id);
            if (info == null)
            {
                return HttpNotFound();
            }
            return View(info);
        }

        // POST: Form/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Info info = db.Info.Find(id);
            db.Info.Remove(info);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserData(string name, string phone, string email, string gender) {

            Info info = new Info { Name = name, Phone = phone, Email = email, Gender = gender };
            db.Info.Add(info);
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
