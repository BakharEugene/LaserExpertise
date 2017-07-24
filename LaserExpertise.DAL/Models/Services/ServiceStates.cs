using System.Collections.Generic;

namespace LaserExpertise.DAL.Models.Services
{
    public class ServiceStates
    {
        public int Id { get; set; }

        public int? ServiceId{ get; set; }
        public virtual Service Service{ get; set; }

        public int? UserId { get; set; }
        public virtual User.User User{ get; set; }

        public bool State { get; set; }


        public ServiceStates(User.User user, Service service, bool state=false)
        {
            this.User = user;
            this.UserId = user.Id;
            this.Service = service;
            this.ServiceId = service.Id;
            this.State = state;
        }
    }
}