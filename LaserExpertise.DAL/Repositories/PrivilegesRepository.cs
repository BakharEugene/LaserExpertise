using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class PrivilegesRepository : IRepository<Privileges>
    {
        private LaserExpertiseContext _applicationDbContext;

        public PrivilegesRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Privileges> GetAll()
        {
            List<Privileges> Privilegeses = _applicationDbContext.Privilegeses.ToList();
            return Privilegeses.ToList();
        }

        public Privileges GetById(int? id)
        {
            return _applicationDbContext.Privilegeses.Find(id);
        }

        public void Create(Privileges item)
        {
            _applicationDbContext.Privilegeses.Add(item);
        }

        public void Update(Privileges item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Privilegeses.Find(id) != null)
            {
                _applicationDbContext.Privilegeses.Remove(_applicationDbContext.Privilegeses.Find(id));
            }
        }
    }
}