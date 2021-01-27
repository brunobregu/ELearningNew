using ELearningProject.ViewModel;
using ELearningProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers.Admin
{
    public class InstruktorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Instruktor
        public ActionResult Index()
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            //Useri nuk eshte loguar
            if (userId == 0)
            {
                return RedirectToAction("Login", "User");
            }
            var instruktor = db.User.Where(x => x.RoleId == 2);
            return View(instruktor);
        }


        public ActionResult AddInstruktor()
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
        public ActionResult AddInstruktor(RegisterVM obj)
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
                RoleId = 2
            };

            db.User.Add(u);
            db.SaveChanges();
            return RedirectToAction("Index", "Instruktor");
        }
    }
}