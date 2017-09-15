using System;
using LaserExpertise.DAL.EF;
using LaserExpertise.DAL.Repositories;

namespace LaserExpertise.DAL.Models.Information
{
    public class UnitOfWork : IDisposable
    {
        private LaserExpertiseContext db = new LaserExpertiseContext();
        private PrivilegesRepository privilegesRepository;
        private ArtworkGenreRepository artworkGenreRepository;
        private ArtworkRepository artworkRepository;
        private ArtworkTypePositionRepository artworkTypePositionRepository;
        private UsersRepository usersRepository;



        public PrivilegesRepository Privileges
        {
            get
            {
                if (privilegesRepository == null)
                    privilegesRepository = new PrivilegesRepository(db);
                return privilegesRepository;
            }
        }
        public ArtworkRepository Artworks
        {
            get
            {
                if (artworkRepository== null)
                    artworkRepository = new ArtworkRepository(db);
                return artworkRepository;
            }
        }
        public UsersRepository Users
        {
            get
            {
                if (usersRepository == null)
                    usersRepository = new UsersRepository(db);
                return usersRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}