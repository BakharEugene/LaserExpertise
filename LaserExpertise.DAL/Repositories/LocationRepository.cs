using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class LocationRepository:IRepository<LOCATION>
    {
        private LaserExpertiseContext _applicationDbContext;

        public LocationRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<LOCATION> GetAll()
        {
            List<LOCATION> locations = _applicationDbContext.Locations.ToList();
            return locations.ToList();
        }

        public LOCATION GetById(int? id)
        {
            return _applicationDbContext.Locations.Find(id);
        }

        public void Create(LOCATION item)
        {
            _applicationDbContext.Locations.Add(item);
        }

        public void Update(LOCATION item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Locations.Find(id) != null)
            {
                _applicationDbContext.Locations.Remove(_applicationDbContext.Locations.Find(id));
            }
        }
    }
}