using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class CountryRepository : IRepository<COUNTRY>
    {
        private LaserExpertiseContext _applicationDbContext;

        public CountryRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<COUNTRY> GetAll()
        {
            List<COUNTRY> Countrys = _applicationDbContext.Countrys.ToList();
            return Countrys.ToList();
        }

        public COUNTRY GetById(int? id)
        {
            return _applicationDbContext.Countrys.Find(id);
        }

        public void Create(COUNTRY item)
        {
            _applicationDbContext.Countrys.Add(item);
        }

        public void Update(COUNTRY item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Countrys.Find(id) != null)
            {
                _applicationDbContext.Countrys.Remove(_applicationDbContext.Countrys.Find(id));
            }
        }
    }
}