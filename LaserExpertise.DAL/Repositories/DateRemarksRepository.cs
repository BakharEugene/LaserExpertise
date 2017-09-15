using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class DateRemarksRepository:IRepository<DATE_REMARKS>
    {
        private LaserExpertiseContext _applicationDbContext;

        public DateRemarksRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<DATE_REMARKS> GetAll()
        {
            List<DATE_REMARKS> DateRemarks = _applicationDbContext.DateRemarks.ToList();
            return DateRemarks.ToList();
        }

        public DATE_REMARKS GetById(int? id)
        {
            return _applicationDbContext.DateRemarks.Find(id);
        }

        public void Create(DATE_REMARKS item)
        {
            _applicationDbContext.DateRemarks.Add(item);
        }

        public void Update(DATE_REMARKS item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.DateRemarks.Find(id) != null)
            {
                _applicationDbContext.DateRemarks.Remove(_applicationDbContext.DateRemarks.Find(id));
            }
        }
    }
}