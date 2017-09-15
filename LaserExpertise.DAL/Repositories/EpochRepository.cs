using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class EpochRepository:IRepository<EPOCH>
    {
        private LaserExpertiseContext _applicationDbContext;

        public EpochRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<EPOCH> GetAll()
        {
            List<EPOCH> Epochs = _applicationDbContext.Epochs.ToList();
            return Epochs.ToList();
        }

        public EPOCH GetById(int? id)
        {
            return _applicationDbContext.Epochs.Find(id);
        }

        public void Create(EPOCH item)
        {
            _applicationDbContext.Epochs.Add(item);
        }

        public void Update(EPOCH item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Epochs.Find(id) != null)
            {
                _applicationDbContext.Epochs.Remove(_applicationDbContext.Epochs.Find(id));
            }
        }
    }
}