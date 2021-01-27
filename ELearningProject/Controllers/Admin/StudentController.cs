using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers.Admin
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            if (userId == 0)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
    }
}