using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class ArtworkTypePositionRepository:IRepository<ARTWORK_TYPE_POSITION>
    {

        private LaserExpertiseContext _applicationDbContext;

        public ArtworkTypePositionRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<ARTWORK_TYPE_POSITION> GetAll()
        {
            List<ARTWORK_TYPE_POSITION> ArtworkTypePositions = _applicationDbContext.ArtworkTypePositions.ToList();
            return ArtworkTypePositions.ToList();
        }

        public ARTWORK_TYPE_POSITION GetById(int? id)
        {
            return _applicationDbContext.ArtworkTypePositions.Find(id);
        }

        public void Create(ARTWORK_TYPE_POSITION item)
        {
            _applicationDbContext.ArtworkTypePositions.Add(item);
        }

        public void Update(ARTWORK_TYPE_POSITION item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.ArtworkTypePositions.Find(id) != null)
            {
                _applicationDbContext.ArtworkTypePositions.Remove(_applicationDbContext.ArtworkTypePositions.Find(id));
            }
        }

    }
}