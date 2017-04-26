using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
