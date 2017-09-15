using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class ArtworkGenreRepository:IRepository<ARTWORK_GENRE>
    {
        private LaserExpertiseContext _applicationDbContext;

        public ArtworkGenreRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<ARTWORK_GENRE> GetAll()
        {
            List<ARTWORK_GENRE> ArtworkGenres = _applicationDbContext.ArtworkGenres.ToList();
            return ArtworkGenres.ToList();
        }

        public ARTWORK_GENRE GetById(int? id)
        {
            return _applicationDbContext.ArtworkGenres.Find(id);
        }

        public void Create(ARTWORK_GENRE item)
        {
            _applicationDbContext.ArtworkGenres.Add(item);
        }

        public void Update(ARTWORK_GENRE item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.ArtworkGenres.Find(id) != null)
            {
                _applicationDbContext.ArtworkGenres.Remove(_applicationDbContext.ArtworkGenres.Find(id));
            }
        }
    }
}