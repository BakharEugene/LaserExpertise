using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class PaintsRepository:IRepository<PAINTS>
    {
        private LaserExpertiseContext _applicationDbContext;

        public PaintsRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<PAINTS> GetAll()
        {
            List<PAINTS> paints = _applicationDbContext.Paints.ToList();
            return paints.ToList();
        }

        public PAINTS GetById(int? id)
        {
            return _applicationDbContext.Paints.Find(id);
        }

        public void Create(PAINTS item)
        {
            _applicationDbContext.Paints.Add(item);
        }

        public void Update(PAINTS item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Paints.Find(id) != null)
            {
                _applicationDbContext.Paints.Remove(_applicationDbContext.Paints.Find(id));
            }
        }
    }
}