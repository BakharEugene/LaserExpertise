using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class OrganizationRepository:IRepository<Organization>
    {
        private LaserExpertiseContext _applicationDbContext;

        public OrganizationRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Organization> GetAll()
        {
            List<Organization>organizations  = _applicationDbContext.Organizations.ToList();
            return organizations.ToList();
        }

        public Organization GetById(int? id)
        {
            return _applicationDbContext.Organizations.Find(id);
        }

        public void Create(Organization item)
        {
            _applicationDbContext.Organizations.Add(item);
        }

        public void Update(Organization item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Organizations.Find(id) != null)
            {
                _applicationDbContext.Organizations.Remove(_applicationDbContext.Organizations.Find(id));
            }
        }
    }
}