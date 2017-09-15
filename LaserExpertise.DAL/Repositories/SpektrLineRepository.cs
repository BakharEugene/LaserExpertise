using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class SpektrLineRepository:IRepository<SPEKTR_LINE>
    {
        private LaserExpertiseContext _applicationDbContext;

        public SpektrLineRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<SPEKTR_LINE> GetAll()
        {
            List<SPEKTR_LINE> spektrLines = _applicationDbContext.SpektrLines.ToList();
            return spektrLines.ToList();
        }

        public SPEKTR_LINE GetById(int? id)
        {
            return _applicationDbContext.SpektrLines.Find(id);
        }

        public void Create(SPEKTR_LINE item)
        {
            _applicationDbContext.SpektrLines.Add(item);
        }

        public void Update(SPEKTR_LINE item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.SpektrLines.Find(id) != null)
            {
                _applicationDbContext.SpektrLines.Remove(_applicationDbContext.SpektrLines.Find(id));
            }
        }
    }
}