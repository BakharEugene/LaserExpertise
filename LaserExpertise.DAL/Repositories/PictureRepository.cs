using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.EF;
using LaserExpertise.DAL.Models.Picture;

namespace LaserExpertise.DAL.Repositories
{
    public class PictureRepository:IRepository<Picture>
    {
        private LaserExpertiseContext _applicationDbContext;

        public PictureRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Picture> GetAll()
        {
            List<Picture> Pictures = _applicationDbContext.Pictures.ToList();
            return Pictures.ToList();
        }

        public Picture GetById(int? id)
        {
            return _applicationDbContext.Pictures.Find(id);
        }

        public void Create(Picture item)
        {
            _applicationDbContext.Pictures.Add(item);
        }

        public void Update(Picture item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Pictures.Find(id) != null)
            {
                _applicationDbContext.Pictures.Remove(_applicationDbContext.Pictures.Find(id));
            }
        }
    }
}