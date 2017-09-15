using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class PigmentsRepository:IRepository<PIGMENTS>
    {
        private LaserExpertiseContext _applicationDbContext;

        public PigmentsRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<PIGMENTS> GetAll()
        {
            List<PIGMENTS> pigments = _applicationDbContext.Pigments.ToList();
            return pigments.ToList();
        }

        public PIGMENTS GetById(int? id)
        {
            return _applicationDbContext.Pigments.Find(id);
        }

        public void Create(PIGMENTS item)
        {
            _applicationDbContext.Pigments.Add(item);
        }

        public void Update(PIGMENTS item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Pigments.Find(id) != null)
            {
                _applicationDbContext.Pigments.Remove(_applicationDbContext.Pigments.Find(id));
            }
        }
    }
}