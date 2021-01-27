using ELearningProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kurset()
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            //Useri nuk eshte loguar
            if (userId == 0)
            {
                return RedirectToAction("Login", "User");
            }
            ViewBag.EmriKursit = new SelectList(db.Kursi, "Id", "EmriKursit");
            var kurse = db.Kursi;
            return View(kurse);
        }


        [HttpPost]
        public ActionResult Kurset(int id)
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            if (id != 0)
            {
                UserToKursi u = new UserToKursi
                {
                    UserId = userId,
                    KursId = id
                };
                db.UserToKursi.Add(u);
                db.SaveChanges();
                return RedirectToAction("Kurset");
            }
            else
            {
                return Content("Dicka shkoi gabim ...");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}