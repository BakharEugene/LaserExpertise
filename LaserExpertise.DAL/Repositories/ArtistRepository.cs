using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.EF;
using LaserExpertise.DAL.Models.Artist;

namespace LaserExpertise.DAL.Repositories
{
    public class ArtistRepository:IRepository<Artist>
    {
        private LaserExpertiseContext _applicationDbContext;

        public ArtistRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Artist> GetAll()
        {
            List<Artist> Artists = _applicationDbContext.Artists.ToList();
            return Artists.ToList();
        }

        public Artist GetById(int? id)
        {
            return _applicationDbContext.Artists.Find(id);
        }

        public void Create(Artist item)
        {
            _applicationDbContext.Artists.Add(item);
        }

        public void Update(Artist item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Artists.Find(id) != null)
            {
                _applicationDbContext.Artists.Remove(_applicationDbContext.Artists.Find(id));
            }
        }
    }
}