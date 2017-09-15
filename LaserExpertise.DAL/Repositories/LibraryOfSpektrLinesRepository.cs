using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.EF;

namespace LaserExpertise.DAL.Repositories
{
    public class LibraryOfSpektrLinesRepository:IRepository<LIBRARY_OF_SPEKTR_LINES>
    {
        private LaserExpertiseContext _applicationDbContext;

        public LibraryOfSpektrLinesRepository(LaserExpertiseContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<LIBRARY_OF_SPEKTR_LINES> GetAll()
        {
            List<LIBRARY_OF_SPEKTR_LINES> libraryOfSpektrLines = _applicationDbContext.LibraryOfSpektrLines.ToList();
            return libraryOfSpektrLines.ToList();
        }

        public LIBRARY_OF_SPEKTR_LINES GetById(int? id)
        {
            return _applicationDbContext.LibraryOfSpektrLines.Find(id);
        }

        public void Create(LIBRARY_OF_SPEKTR_LINES item)
        {
            _applicationDbContext.LibraryOfSpektrLines.Add(item);
        }

        public void Update(LIBRARY_OF_SPEKTR_LINES item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.LibraryOfSpektrLines.Find(id) != null)
            {
                _applicationDbContext.LibraryOfSpektrLines.Remove(_applicationDbContext.LibraryOfSpektrLines.Find(id));
            }
        }
    }
}