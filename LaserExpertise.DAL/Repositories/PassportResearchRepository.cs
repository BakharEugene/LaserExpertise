using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class PassportResearchRepository:IRepository<PASSPORT_RESEARCH>
    {
        private LaserExpertiseContext _applicationDbContext;

        public PassportResearchRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<PASSPORT_RESEARCH> GetAll()
        {
            List<PASSPORT_RESEARCH> passportResearchs = _applicationDbContext.PassportResearchs.ToList();
            return passportResearchs.ToList();
        }

        public PASSPORT_RESEARCH GetById(int? id)
        {
            return _applicationDbContext.PassportResearchs.Find(id);
        }

        public void Create(PASSPORT_RESEARCH item)
        {
            _applicationDbContext.PassportResearchs.Add(item);
        }

        public void Update(PASSPORT_RESEARCH item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.PassportResearchs.Find(id) != null)
            {
                _applicationDbContext.PassportResearchs.Remove(_applicationDbContext.PassportResearchs.Find(id));
            }
        }
    }
}