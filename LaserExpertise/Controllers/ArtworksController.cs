using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LaserExpertise.DAL.EF;
using LaserExpertise.DAL.Models.Artwork;
using LaserExpertise.DAL.Models.Information;
using LaserExpertise.DAL.Models.Picture;
using LaserExpertise.Models;

namespace LaserExpertise.Controllers
{
    public class ArtworksController : Controller
    {
        UnitOfWork unit = new UnitOfWork();
        [HttpGet]
        public JsonResult Index()
        {
            var artworks = unit.Artworks.GetAll();
            return Json(artworks, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult Detail(int id)
        {
            var artwork = unit.Artworks.GetById(id);
            return Json(artwork, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Create(Artwork artwork)
        {
                return Json("Kek", JsonRequestBehavior.AllowGet);
        }

        // GET: Artworks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artwork artwork = unit.Artworks.GetById(id);
            if (artwork == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtistId = new SelectList(unit.Users.GetAll(), "Id", "Email", artwork.ArtistId);
            return View(artwork);
        }

        // POST: Artworks/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ArtistId,Genre,School,Description")] Artwork artwork)
        {
            if (ModelState.IsValid)
            {
                unit.Artworks.Update(artwork);
                unit.Save();
                return RedirectToAction("Index");
            }
            ViewBag.ArtistId = new SelectList(unit.Users.GetAll(), "Id", "Email", artwork.ArtistId);
            return View(artwork);
        }

        // GET: Artworks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artwork artwork = unit.Artworks.GetById(id);
            if (artwork == null)
            {
                return HttpNotFound();
            }
            return View(artwork);
        }

        // POST: Artworks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artwork artwork = unit.Artworks.GetById(id);
            unit.Artworks.Delete(artwork.Id);
            unit.Save();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Upload(IEnumerable<HttpPostedFileBase> uploads, Artwork artwork)
        {
            if (uploads != null)
            {
                foreach (var file in uploads)
                {
                    if (file != null)
                    {
                        // получаем имя файла
                        string fileName = System.IO.Path.GetFileName(file.FileName);
                        // сохраняем файл в папку Files в проекте
                        file.SaveAs(Server.MapPath("~/Files/" + fileName));
                        unit.Pictures.Create(new Picture("~/Files/" + fileName, artwork));

                    }
                }
            }

            unit.Artworks.Create(artwork);
            unit.Save();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unit.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
