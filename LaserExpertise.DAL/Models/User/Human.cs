using System;
using System.Collections.Generic;
using System.Text;
using LaserExpertise.DAL.Models.Information;

namespace LaserExpertise.DAL.Models.User
{
    public class Human
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Skype { get; set; }
        public Enums.Genders Gender { get; set; }
    }
}
