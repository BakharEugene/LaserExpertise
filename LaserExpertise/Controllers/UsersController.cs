using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using LaserExpertise.DAL.Data;
using LaserExpertise.DAL.Models.Information;

namespace LaserExpertise.Controllers
{
    public class UsersController : Controller
    {
        UnitOfWork unit = new UnitOfWork();
        // GET: Users
        [HttpGet]
        public JsonResult Users()
        {
            return Json(unit.Users.GetAll(), JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult Users(int id)
        {
            return Json(unit.Users.GetById(id), JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public JsonResult Create(User user)
        {
            User tempuser = null;

            tempuser = unit.Users.GetAll().FirstOrDefault(x => x.Login_Name == user.Login_Name);
            if (tempuser == null)
            {
                unit.Users.Create(user);
                unit.Save();
                return Json("Registration success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("This email already used", JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public JsonResult Login(User login)
        {
            
            User user = unit.Users.GetAll().FirstOrDefault(x => x.Login_Name == login.Login_Name && x.Password == login.Password);
            return Json(user, JsonRequestBehavior.AllowGet);
        }
        [HttpPut]
        public string UsersUpdate(int id)
        {
            return "kek";
        }
        [HttpDelete]
        public string UsersRemove(int id)
        {
            unit.Users.Delete(id);
            unit.Save();
            return "kek";
        }
    }
}