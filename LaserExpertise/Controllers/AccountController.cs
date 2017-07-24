using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Security;
using LaserExpertise.DAL.EF;
using LaserExpertise.DAL.Models.Information;
using LaserExpertise.DAL.Models.Services;
using LaserExpertise.DAL.Models.User;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using System.Collections;
using System.Collections.Generic;
using System.Web.Helpers;

namespace LaserExpertise.Controllers
{
    public class AccountController : Controller
    {
        UnitOfWork unit = new UnitOfWork();
        private LaserExpertiseContext db = new LaserExpertiseContext();

        [HttpPost]
        public void Login(User user)
        {
            unit.Users.Create(user);
            unit.Save();
        }
        [HttpPost]
        public void Login(string kek)
        {

            if (ModelState.IsValid)
            {
                // поиск пользователя в бд
                User user = null;

                //user = unit.Users.GetAll().FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
                ;

                if (user != null)
                {
                    //  FormsAuthentication.SetAuthCookie(model.Email, true);
                    // return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
                }
            }
        }



       
        [Authorize]
        public ActionResult Profile()
        {
            User user = unit.Users.GetAll().FirstOrDefault(u => u.Email == User.Identity.Name);
            EditModel edit = new EditModel
            {
                FirstName = user.FirstName,
                Gender = user.Gender,
                LastName = user.LastName,
                Id = user.Id,
                Skype = user.Skype,
                Telephone =user.Telephone,
                Role = user.Role,
                RoleId = user.RoleId
            };
            return View(edit);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            ViewBag.Roles = new SelectList(unit.Roles.GetAll(), "Id", "Name");

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User User = unit.Users.GetById(id);//db.Monuments.Find(id);
            if (User == null)
            {
                return HttpNotFound();
            }
            return View(User);
        }

        // POST: Monuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(User User)
        {
            if (ModelState.IsValid)
            {
                User.Role = unit.Roles.GetById(User.RoleId);
                unit.Users.Update(User);
                unit.Save();
                return RedirectToAction("Index");
            }
            return View(User);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Profile(EditModel edit)
        {
            User user = unit.Users.GetAll().FirstOrDefault(u => u.Email == User.Identity.Name);

            user.Telephone = edit.Telephone;
            user.Skype = edit.Skype;
            user.LastName = edit.LastName;
            user.Gender = edit.Gender;
            user.FirstName = edit.FirstName;
            unit.Users.Update(user);
            unit.Save();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = null;
                
                    user = unit.Users.GetAll().FirstOrDefault(u => u.Email == model.Email);
                
                if (user == null)
                {
                    user = new User()
                    {
                        Email = model.Email,
                        Password = model.Password,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        ConfirmPassword = model.ConfirmPassword,
                        Gender = model.Gender,
                        Skype = model.Skype,
                        Telephone = model.Telephone,
                        //ServiceStateses = new List<ServiceStates>(),
                        RoleId = 3
                    };
                    foreach(var service in unit.Services.GetAll())
                    {
                        ServiceStates serviceState = new ServiceStates(user, service);
                        //user.ServiceStateses.Add(serviceState);
                        unit.ServiceStates.Create(serviceState);
                    }
                    // создаем нового пользователя

                    unit.Users.Create(user);
                    
                        unit.Save();
                        //db.SaveChanges();
                        user = unit.Users.GetAll().Where(u => u.Email == model.Email && u.Password == model.Password).FirstOrDefault();
                    // если пользователь удачно добавлен в бд
                    if (User != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Email, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User User = unit.Users.GetById(id);
            if (User == null)
            {
                return HttpNotFound();
            }
            return View(User);
        }

        // POST: Monuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            User User = unit.Users.GetById(id);
            unit.Users.Delete(User.Id);
            unit.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}