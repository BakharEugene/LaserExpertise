using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class HistoricalPeriodRepository:IRepository<HISTORICAL_PERIOD>
    {
        private LaserExpertiseContext _applicationDbContext;

        public HistoricalPeriodRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<HISTORICAL_PERIOD> GetAll()
        {
            List<HISTORICAL_PERIOD> historicalPeriods = _applicationDbContext.HistoricalPeriods.ToList();
            return historicalPeriods.ToList();
        }

        public HISTORICAL_PERIOD GetById(int? id)
        {
            return _applicationDbContext.HistoricalPeriods.Find(id);
        }

        public void Create(HISTORICAL_PERIOD item)
        {
            _applicationDbContext.HistoricalPeriods.Add(item);
        }

        public void Update(HISTORICAL_PERIOD item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.HistoricalPeriods.Find(id) != null)
            {
                _applicationDbContext.HistoricalPeriods.Remove(_applicationDbContext.HistoricalPeriods.Find(id));
            }
        }
    }
}