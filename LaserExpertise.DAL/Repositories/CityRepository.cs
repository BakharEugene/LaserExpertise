using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class CityRepository:IRepository<CITY>
    {
        private LaserExpertiseContext _applicationDbContext;

        public CityRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<CITY> GetAll()
        {
            List<CITY> Citys = _applicationDbContext.Citys.ToList();
            return Citys.ToList();
        }

        public CITY GetById(int? id)
        {
            return _applicationDbContext.Citys.Find(id);
        }

        public void Create(CITY item)
        {
            _applicationDbContext.Citys.Add(item);
        }

        public void Update(CITY item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Citys.Find(id) != null)
            {
                _applicationDbContext.Citys.Remove(_applicationDbContext.Citys.Find(id));
            }
        }
    }
}