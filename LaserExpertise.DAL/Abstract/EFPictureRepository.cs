using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserExpertise.DAL3.Abstract
{
    public class EFPictureRepository : IPictureRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Picture> Pictures
        {
            get { return context.Pictures; }
        }

        public void SavePicture(Picture picture)
        {
            if (picture.PictureID == 0)
            {
                context.Products.Add(picture);
            }
            else
            {
                Picture dbEntry = context.Pictures.Find(picture.PictureID);
                if (dbEntry != null)
                {
                    dbEntry.Name = picture.Name;
                    dbEntry.Description = picture.Description;
                    dbEntry.Price = picture.Price;
                    dbEntry.Category = picture.Category;
                    dbEntry.ImageData = picture.ImageData;
                    dbEntry.ImageMimeType = picture.ImageMimeType;
                }
            }
            context.SaveChanges();
        }

        public Picture DeletePicture(int pictureID)
        {
            Picture dbEntry = context.Products.Find(pictureID);
            if (dbEntry != null)
            {
                context.Pictures.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
