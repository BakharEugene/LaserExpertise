using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class FotoRepository:IRepository<FOTO>
    {
        private LaserExpertiseContext _applicationDbContext;

        public FotoRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<FOTO> GetAll()
        {
            List<FOTO> fotos = _applicationDbContext.Fotos.ToList();
            return fotos.ToList();
        }

        public FOTO GetById(int? id)
        {
            return _applicationDbContext.Fotos.Find(id);
        }

        public void Create(FOTO item)
        {
            _applicationDbContext.Fotos.Add(item);
        }

        public void Update(FOTO item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Fotos.Find(id) != null)
            {
                _applicationDbContext.Fotos.Remove(_applicationDbContext.Fotos.Find(id));
            }
        }
    }
}