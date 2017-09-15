using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class SpektrRepository:IRepository<SPEKTR>
    {
        private LaserExpertiseContext _applicationDbContext;

        public SpektrRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<SPEKTR> GetAll()
        {
            List<SPEKTR> locations = _applicationDbContext.Spektrs.ToList();
            return locations.ToList();
        }

        public SPEKTR GetById(int? id)
        {
            return _applicationDbContext.Spektrs.Find(id);
        }

        public void Create(SPEKTR item)
        {
            _applicationDbContext.Spektrs.Add(item);
        }

        public void Update(SPEKTR item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Spektrs.Find(id) != null)
            {
                _applicationDbContext.Spektrs.Remove(_applicationDbContext.Spektrs.Find(id));
            }
        }
    }
}