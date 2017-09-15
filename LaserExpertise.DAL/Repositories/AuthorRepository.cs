using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class AuthorRepository:IRepository<AUTHOR>
    {
        private LaserExpertiseContext _applicationDbContext;

        public AuthorRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<AUTHOR> GetAll()
        {
            List<AUTHOR> Authors = _applicationDbContext.Authors.ToList();
            return Authors.ToList();
        }

        public AUTHOR GetById(int? id)
        {
            return _applicationDbContext.Authors.Find(id);
        }

        public void Create(AUTHOR item)
        {
            _applicationDbContext.Authors.Add(item);
        }

        public void Update(AUTHOR item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Authors.Find(id) != null)
            {
                _applicationDbContext.Authors.Remove(_applicationDbContext.Authors.Find(id));
            }
        }
    }
}