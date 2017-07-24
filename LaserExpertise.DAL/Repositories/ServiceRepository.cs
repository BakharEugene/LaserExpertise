using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.EF;
using LaserExpertise.DAL.Models.Services;

namespace LaserExpertise.DAL.Repositories
{
    public class ServiceRepository:IRepository<Service>
    {
        private LaserExpertiseContext _applicationDbContext;

        public ServiceRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Service> GetAll()
        {
            List<Service> Services = _applicationDbContext.Services.ToList();
            return Services.ToList();
        }

        public Service GetById(int? id)
        {
            return _applicationDbContext.Services.Find(id);
        }

        public void Create(Service item)
        {
            _applicationDbContext.Services.Add(item);
        }

        public void Update(Service item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Services.Find(id) != null)
            {
                _applicationDbContext.Services.Remove(_applicationDbContext.Services.Find(id));
            }
        }
    }
}