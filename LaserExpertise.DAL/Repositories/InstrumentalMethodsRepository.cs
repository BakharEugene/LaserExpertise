using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class InstrumentalMethodsRepository:IRepository<INSTRUMENTAL_METHODS>
    {
        private LaserExpertiseContext _applicationDbContext;

        public InstrumentalMethodsRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<INSTRUMENTAL_METHODS> GetAll()
        {
            List<INSTRUMENTAL_METHODS> instrumentalMethods = _applicationDbContext.InstrumentalMethods.ToList();
            return instrumentalMethods.ToList();
        }

        public INSTRUMENTAL_METHODS GetById(int? id)
        {
            return _applicationDbContext.InstrumentalMethods.Find(id);
        }

        public void Create(INSTRUMENTAL_METHODS item)
        {
            _applicationDbContext.InstrumentalMethods.Add(item);
        }

        public void Update(INSTRUMENTAL_METHODS item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.InstrumentalMethods.Find(id) != null)
            {
                _applicationDbContext.InstrumentalMethods.Remove(_applicationDbContext.InstrumentalMethods.Find(id));
            }
        }
    }
}