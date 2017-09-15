
using LaserExpertise.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using LaserExpertise.DAL.Data;

namespace LaserExpertise.DAL.Models.Providers
{
    public class CustomRoleProvider : RoleProvider
    {
        public override string[] GetRolesForUser(string username)
        {
            string[] role = new string[] { };
            using (LaserExpertiseContext db = new LaserExpertiseContext())
            {
                // Получаем пользователя
                User user = db.Users.FirstOrDefault(u => u.Login_Name == username);
                if (user != null)
                {
                    // получаем роль
                    Privileges userRole = db.Privilegeses.Find(user.id_privilege);
                    if (userRole != null)
                        role = new string[] { userRole.User_Type };
                }
            }
            return role;
        }
        public override void CreateRole(string roleName)
        {
            Privileges newRole = new Privileges() { User_Type = roleName };
            LaserExpertiseContext db = new LaserExpertiseContext();
            db.Privilegeses.Add(newRole);
            db.SaveChanges();
        }
        public override bool IsUserInRole(string username, string roleName)
        {
            bool outputResult = false;
            // Находим пользователя
            using (LaserExpertiseContext db = new LaserExpertiseContext())
            {
                // Получаем пользователя
                User user = db.Users.FirstOrDefault(u => u.Login_Name == username);
                if (user != null)
                {
                    
                    Privileges userRole = db.Privilegeses.Find(user.id_privilege);
                    
                    if (userRole != null && userRole.User_Type == roleName)
                        outputResult = true;
                }
            }
            return outputResult;
        }
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}