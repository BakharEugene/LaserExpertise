using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class ArtworkRepository : IRepository<ARTWORK>
    {
        private LaserExpertiseContext _applicationDbContext;

        public ArtworkRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<ARTWORK> GetAll()
        {
            List<ARTWORK> Artworks = _applicationDbContext.Artworks.ToList();
            return Artworks.ToList();
        }

        public ARTWORK GetById(int? id)
        {
            return _applicationDbContext.Artworks.Find(id);
        }

        public void Create(ARTWORK item)
        {
            _applicationDbContext.Artworks.Add(item);
        }

        public void Update(ARTWORK item)
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