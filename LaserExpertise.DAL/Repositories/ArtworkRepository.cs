using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaserExpertise.DAL.EF;
using LaserExpertise.DAL.Models.Artwork;
using LaserExpertise.DAL.Repositories;

namespace LaserExpertise.DAL.Repositories
{
    public class ArtworkRepository:IRepository<Artwork>
    {
        private LaserExpertiseContext _applicationDbContext;

        public ArtworkRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Artwork> GetAll()
        {
            List<Artwork> Artworks = _applicationDbContext.Artworks.ToList();
            return Artworks.ToList();
        }

        public Artwork GetById(int? id)
        {
            return _applicationDbContext.Artworks.Find(id);
        }

        public void Create(Artwork item)
        {
            _applicationDbContext.Artworks.Add(item);
        }

        public void Update(Artwork item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Artworks.Find(id) != null)
            {
                _applicationDbContext.Artworks.Remove(_applicationDbContext.Artworks.Find(id));
            }
        }
    }
}
