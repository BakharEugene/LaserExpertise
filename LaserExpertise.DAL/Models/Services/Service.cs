using System.Collections.Generic;

namespace LaserExpertise.DAL.Models.Services
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual ICollection<ServiceStates> ServiceStates { get; set; }
    }
}