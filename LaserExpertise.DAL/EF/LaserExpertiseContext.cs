using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaserExpertise.DAL.Models.Artist;
using LaserExpertise.DAL.Models.Artwork;
using LaserExpertise.DAL.Models.Picture;
using LaserExpertise.DAL.Models.User;

namespace LaserExpertise.DAL.EF
{
    public  class LaserExpertiseContext:DbContext
    {
        public LaserExpertiseContext()
            : base("LaserExpertiseContext")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }
    }
}
