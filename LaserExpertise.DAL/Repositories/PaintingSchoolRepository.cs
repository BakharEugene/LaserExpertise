using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class PaintingSchoolRepository:IRepository<PAINTING_SCHOOL>
    {
        private LaserExpertiseContext _applicationDbContext;

        public PaintingSchoolRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<PAINTING_SCHOOL> GetAll()
        {
            List<PAINTING_SCHOOL> paintingSchools = _applicationDbContext.PaintingSchools.ToList();
            return paintingSchools.ToList();
        }

        public PAINTING_SCHOOL GetById(int? id)
        {
            return _applicationDbContext.PaintingSchools.Find(id);
        }

        public void Create(PAINTING_SCHOOL item)
        {
            _applicationDbContext.PaintingSchools.Add(item);
        }

        public void Update(PAINTING_SCHOOL item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.PaintingSchools.Find(id) != null)
            {
                _applicationDbContext.PaintingSchools.Remove(_applicationDbContext.PaintingSchools.Find(id));
            }
        }
    }
}