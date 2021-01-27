using ELearningProject.ViewModel;
using ELearningProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.Entity;

namespace ELearningProject.Controllers.Admin
{
    public class KursetController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Kurset
        public ActionResult Index()
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            //Useri nuk eshte loguar
            if (userId == 0)
            {
                return RedirectToAction("Login", "User");
            }
            var kurse = db.Kursi;
            return View(kurse);
        }


        public ActionResult AddCourse()
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
        public ActionResult AddCourse(KursVM obj)
        {
            string[] allowedFileTypes = { ".gif", ".png", ".jpeg", ".jpg" };
            var file = obj.Picture;
            bool u_gjet = false;
            var extension = Path.GetExtension(file.FileName);
            if (file != null)
            {
                for(int i = 0; i < 4; i++)
                {
                    if (extension.Equals(allowedFileTypes[i]))
                    {
                        u_gjet = true;
                    }
                }
                if (u_gjet == true)
                {
                    string id_and_extension = obj.EmriKursit + extension;
                    string imgUrl = "~/Profile Images/" + id_and_extension;
                    Kursi k = new Kursi
                    {
                        EmriKursit = obj.EmriKursit,
                        Pershkrimi = obj.Pershkrimi,
                        CreatedOn = DateTime.Now,
                        ImagePath = imgUrl
                    };
                    db.Kursi.Add(k);
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
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.FileMessage = "Ju duhet te zgjidhni nje imazh";
                    return View();
                }
                
            }
            else
            {
                ViewBag.Message = "Ju duhet te zgjidhni nje fjale";
                return View();
            }
                

        }
    }
}