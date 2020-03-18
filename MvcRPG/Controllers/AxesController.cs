using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcRPG.Models;
using MvcRPG.ModelsDTO;
using MvcRPG.Services;

namespace MvcRPG.Controllers
{
    public class AxesController : Controller
    {
        private WeaponDb db = new WeaponDb();
        private AxeService axeService = new AxeService();

        // GET: Axes
        public ActionResult Index()
        {
            var axes = axeService.GetAllAxes();
            return View(axes);
        }

        // GET: Axes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Axe axe = db.Axes.Find(id);
            if (axe == null)
            {
                return HttpNotFound();
            }
            return View(axe);
        }

        // GET: Axes/Create
        public ActionResult Create()
        {
            ViewBag.EnchantmentId = new SelectList(db.Enchantments, "EnchantmentId", "Element");
            return View();
        }

        // POST: Axes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AxeId,Name,Attack,Handler,EnchantmentId")] AxeDTO axe)
        {
            if (ModelState.IsValid)
            {
                axeService.AddNewAxe(axe);
                return RedirectToAction("Index");
            }

            ViewBag.EnchantmentId = new SelectList(db.Enchantments, "EnchantmentId", "Element", axe.EnchantmentId);
            return View(axe);
        }

        // GET: Axes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Axe axe = db.Axes.Find(id);
            if (axe == null)
            {
                return HttpNotFound();
            }
            ViewBag.EnchantmentId = new SelectList(db.Enchantments, "EnchantmentId", "Element", axe.EnchantmentId);
            return View(axe);
        }

        // POST: Axes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AxeId,Name,Attack,Handler,EnchantmentId")] Axe axe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(axe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EnchantmentId = new SelectList(db.Enchantments, "EnchantmentId", "Element", axe.EnchantmentId);
            return View(axe);
        }

        // GET: Axes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Axe axe = db.Axes.Find(id);
            if (axe == null)
            {
                return HttpNotFound();
            }
            return View(axe);
        }

        // POST: Axes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Axe axe = db.Axes.Find(id);
            db.Axes.Remove(axe);
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
