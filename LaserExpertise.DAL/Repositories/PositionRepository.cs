using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class PositionRepository:IRepository<POSITION>
    {
        private LaserExpertiseContext _applicationDbContext;

        public PositionRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<POSITION> GetAll()
        {
            List<POSITION> positions = _applicationDbContext.Positions.ToList();
            return positions.ToList();
        }

        public POSITION GetById(int? id)
        {
            return _applicationDbContext.Positions.Find(id);
        }

        public void Create(POSITION item)
        {
            _applicationDbContext.Positions.Add(item);
        }

        public void Update(POSITION item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Positions.Find(id) != null)
            {
                _applicationDbContext.Positions.Remove(_applicationDbContext.Positions.Find(id));
            }
        }
    }
}