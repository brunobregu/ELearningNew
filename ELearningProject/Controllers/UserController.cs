using ELearningProject.Models;
using ELearningProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class UserController : Controller
    {

        private readonly ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(RegisterVM obj)
        {
            Session["UserId"] = 0;
            bool UserExistis = db.User.Any(x => x.Username == obj.Username);
            if (UserExistis)
            {
                ViewBag.UserNameMessage = "Perdoruesi egziston, provoni tjeter";
                return View();
            }
            bool EmailExistis = db.User.Any(y => y.Email == obj.Email);
            if (EmailExistis)
            {
                ViewBag.EmailMessage = "Email egziston, provoni nje email tjeter";
                return View();
            }
            User u = new User
            {
                Emri = obj.Emri,
                Mbiemri = obj.Mbiemri,
                Username = obj.Username,
                Password = obj.Password,
                Email = obj.Email,
                ImageUrl = "",
                CreatedOn = DateTime.Now,
                RoleId = 3
            };

            db.User.Add(u);
            db.SaveChanges();
            return RedirectToAction("Login", "User");
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Login(LoginVM obj)
        {
            
            bool exist = db.User.Any(u => u.Username == obj.Username && u.Password == obj.Password);
            if (!exist)
            {
                ViewBag.Error = "Perdoruesi nuk egziston";
                return View();
            }
            int userRole = db.User.Single(x => x.Username == obj.Username).RoleId;
            if (userRole == 1)
            {
                Session["Username"] = db.User.Single(x => x.Username == obj.Username).Username;
                Session["UserId"] = db.User.Single(x => x.Username == obj.Username).Id;
                Session["ImageUrl"] = db.User.Single(x => x.Username == obj.Username).ImageUrl;
                return RedirectToAction("Index", "Instruktor");
            }
            else if (userRole == 2)
            {
                Session["Username"] = db.User.Single(x => x.Username == obj.Username).Username;
                Session["UserId"] = db.User.Single(x => x.Username == obj.Username).Id;
                Session["ImageUrl"] = db.User.Single(x => x.Username == obj.Username).ImageUrl;
                return RedirectToAction("About", "Home");
            }
            else
            {
                Session["Username"] = db.User.Single(x => x.Username == obj.Username).Username;
                Session["UserId"] = db.User.Single(x => x.Username == obj.Username).Id;
                Session["ImageUrl"] = db.User.Single(x => x.Username == obj.Username).ImageUrl;
                return RedirectToAction("Index", "Home");
            }
        }


        [HttpGet]
        public ActionResult Logout()
        {
            Session["UserId"] = 0;
            return RedirectToAction("Login", "User");
        }


        public ActionResult ChangePassword()
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            //Useri nuk eshte loguar
            if (userId == 0)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ChangePasswordVM obj)
        {
            bool exist = db.User.Any(x => x.Password == obj.OldPassword);
            if (!exist)
            {
                ModelState.AddModelError("OldPassword", "Passwordi nuk eshte i sakte");
            }
            else
            {
                int userId = Convert.ToInt32(Session["UserId"]);
                User user = db.User.Find(userId);
                user.Password = obj.ConfirmPassword;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        public ActionResult UserProfile()
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            if (userId == 0)
            {
                return RedirectToAction("Login", "User");
            }
            return View(db.User.Find(userId));
        }



        [HttpPost]
        public ActionResult UpdatePicture(PictureVM obj)
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            if (userId == 0)
            {
                return RedirectToAction("Login", "Regjistrohu");
            }
            string[] allowedFileTypes = { ".png", ".jpeg", ".jpg" };
            var file = obj.Picture;
            bool u_gjet = false;
            var extension = Path.GetExtension(file.FileName);
            User u = db.User.Find(userId);
            if (file != null)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (extension.Equals(allowedFileTypes[i]))
                    {
                        u_gjet = true;
                    }
                }
                if (u_gjet == true)
                {
                    //Update Image
                    string id_and_extension = userId + extension;
                    string imgUrl = "~/Profile Images/" + id_and_extension;
                    u.ImageUrl = imgUrl;
                    db.Entry(u).State = EntityState.Modified;
                    db.SaveChanges();
                    var path = Server.MapPath("~/Profile Images/");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    if ((System.IO.File.Exists(path + id_and_extension)))
                    {
                        System.IO.File.Delete(path + id_and_extension);
                    }
                    file.SaveAs((path + id_and_extension));
                    return RedirectToAction("UserProfile");
                }
                else
                {
                    ViewBag.Photo = ("Ju duhet te zgjidhni nje imazh");
                    return RedirectToAction("UserProfile");
                }


            }
            return RedirectToAction("UserProfile");

        }


    }
}