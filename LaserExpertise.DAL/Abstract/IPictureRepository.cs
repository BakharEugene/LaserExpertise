using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserExpertise.DAL3.Abstract
{
    public interface IPictureRepository
    {
        IQueryable<Picture> Picture { get; }
        void SavePicture(Picture picture);
        Picture DeletePicture(int pictureID);
    }
}
