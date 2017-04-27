using LaserExpertise.Domain.Abstract;
using LaserExpertise.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaserExpertise.Pictures.Controllers
{
    public class EditPictureController : Controller
    {
            private IPictureRepository repository;

            public EditPictureController(IPictureRepository repo)
            {
                repository = repo;
            }

            public ViewResult Index()
            {
                return View(repository.Rictures);
            }

            public ViewResult Edit(int pictureId)
            {
                Picture picture = repository.Pictures
                .FirstOrDefault(p => p.PictureID == pictureId);
                return View(product);
            }

            [HttpPost]
            public ActionResult Edit(Picture picture, HttpPostedFileBase image)
            {
                if (ModelState.IsValid)
                {
                    if (image != null)
                    {
                        picture.ImageMimeType = image.ContentType;
                        picture.ImageData = new byte[image.ContentLength];
                        image.InputStream.Read(picture.ImageData, 0, image.ContentLength);
                    }
                    repository.SavePicture(picture);
                    TempData["message"] = string.Format("{0} has been saved", picture.Name);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(picture);
                }
            }

            public ViewResult Create()
            {
                return View("Edit", new Picture());
            }

            [HttpPost]
            public ActionResult Delete(int pictureId)
            {
                Picture deletedPicture = repository.DeletePicture(pictureId);
                if (deletedPicture != null)
                {
                    TempData["message"] = string.Format("{0} was deleted", deletedPicture.Name);
                }
                return RedirectToAction("Index");
            }
        }
}