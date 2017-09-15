using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;
using LaserExpertise.DAL.Data;

namespace LaserExpertise.DAL.Repositories
{
    public class FocusSectionRepository:IRepository<FOCUS_SECTION_SpectralResearch_>
    {
        private LaserExpertiseContext _applicationDbContext;

        public FocusSectionRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<FOCUS_SECTION_SpectralResearch_> GetAll()
        {
            List<FOCUS_SECTION_SpectralResearch_> focusSectionSpectralResearch_S = _applicationDbContext.FocusSectionSpectralResearch_S.ToList();
            return focusSectionSpectralResearch_S.ToList();
        }

        public FOCUS_SECTION_SpectralResearch_ GetById(int? id)
        {
            return _applicationDbContext.FocusSectionSpectralResearch_S.Find(id);
        }

        public void Create(FOCUS_SECTION_SpectralResearch_ item)
        {
            _applicationDbContext.FocusSectionSpectralResearch_S.Add(item);
        }

        public void Update(FOCUS_SECTION_SpectralResearch_ item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.FocusSectionSpectralResearch_S.Find(id) != null)
            {
                _applicationDbContext.FocusSectionSpectralResearch_S.Remove(_applicationDbContext.FocusSectionSpectralResearch_S.Find(id));
            }
        }
    }
}