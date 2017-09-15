using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class PaintingTechniqueRepository:IRepository<PAINTING_TECHNIQUE>
    {
        private LaserExpertiseContext _applicationDbContext;

        public PaintingTechniqueRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<PAINTING_TECHNIQUE> GetAll()
        {
            List<PAINTING_TECHNIQUE> paintingTechniques = _applicationDbContext.PaintingTechniques.ToList();
            return paintingTechniques.ToList();
        }

        public PAINTING_TECHNIQUE GetById(int? id)
        {
            return _applicationDbContext.PaintingTechniques.Find(id);
        }

        public void Create(PAINTING_TECHNIQUE item)
        {
            _applicationDbContext.PaintingTechniques.Add(item);
        }

        public void Update(PAINTING_TECHNIQUE item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.PaintingTechniques.Find(id) != null)
            {
                _applicationDbContext.PaintingTechniques.Remove(_applicationDbContext.PaintingTechniques.Find(id));
            }
        }
    }
}