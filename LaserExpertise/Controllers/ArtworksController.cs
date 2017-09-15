using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;
using LaserExpertise.DAL.Models.Information;

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
        public JsonResult Create(ARTWORK artwork)
        {
            return Json("Kek", JsonRequestBehavior.AllowGet);
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
