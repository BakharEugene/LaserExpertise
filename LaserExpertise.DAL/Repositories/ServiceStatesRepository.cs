using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.EF;
using LaserExpertise.DAL.Models.Services;

namespace LaserExpertise.DAL.Repositories
{
    public class ServiceStatesRepository:IRepository<ServiceStates>
    {
        private LaserExpertiseContext _applicationDbContext;

        public ServiceStatesRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<ServiceStates> GetAll()
        {
            List<ServiceStates> ServiceStatess = _applicationDbContext.ServiceStates.ToList();
            return ServiceStatess.ToList();
        }

        public ServiceStates GetById(int? id)
        {
            return _applicationDbContext.ServiceStates.Find(id);
        }

        public void Create(ServiceStates item)
        {
            _applicationDbContext.ServiceStates.Add(item);
        }

        public void Update(ServiceStates item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.ServiceStates.Find(id) != null)
            {
                _applicationDbContext.ServiceStates.Remove(_applicationDbContext.ServiceStates.Find(id));
            }
        }
    }
}