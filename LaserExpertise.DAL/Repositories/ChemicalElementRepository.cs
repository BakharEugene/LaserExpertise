using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class ChemicalElementRepository:IRepository<CHEMICAL_ELEMENT>
    {
        private LaserExpertiseContext _applicationDbContext;

        public ChemicalElementRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<CHEMICAL_ELEMENT> GetAll()
        {
            List<CHEMICAL_ELEMENT> ChemicalElements = _applicationDbContext.ChemicalElements.ToList();
            return ChemicalElements.ToList();
        }

        public CHEMICAL_ELEMENT GetById(int? id)
        {
            return _applicationDbContext.ChemicalElements.Find(id);
        }

        public void Create(CHEMICAL_ELEMENT item)
        {
            _applicationDbContext.ChemicalElements.Add(item);
        }

        public void Update(CHEMICAL_ELEMENT item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.ChemicalElements.Find(id) != null)
            {
                _applicationDbContext.ChemicalElements.Remove(_applicationDbContext.ChemicalElements.Find(id));
            }
        }
    }
}