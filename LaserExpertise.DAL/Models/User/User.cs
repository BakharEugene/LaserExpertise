using System;
using System.Collections.Generic;
using System.Text;
using LaserExpertise.DAL.Models.Services;

namespace LaserExpertise.DAL.Models.User
{
    public class User:Human
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int? RoleId { get; set; }
        public virtual Role Role { get; set; }

//        public virtual ICollection<ServiceStates> ServiceStateses { get; set; }

    }

}
