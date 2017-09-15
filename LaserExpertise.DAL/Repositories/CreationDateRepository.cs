using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class CreationDateRepository:IRepository<CREATION_DATE>
    {
        private LaserExpertiseContext _applicationDbContext;

        public CreationDateRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<CREATION_DATE> GetAll()
        {
            List<CREATION_DATE> CreationDates = _applicationDbContext.CreationDates.ToList();
            return CreationDates.ToList();
        }

        public CREATION_DATE GetById(int? id)
        {
            return _applicationDbContext.CreationDates.Find(id);
        }

        public void Create(CREATION_DATE item)
        {
            _applicationDbContext.CreationDates.Add(item);
        }

        public void Update(CREATION_DATE item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.CreationDates.Find(id) != null)
            {
                _applicationDbContext.CreationDates.Remove(_applicationDbContext.CreationDates.Find(id));
            }
        }
    }
}