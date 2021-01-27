using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers.Admin
{
    public class QuizAdminController : Controller
    {
        // GET: QuizAdmin
        public ActionResult AddQuiz()
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            //Useri nuk eshte loguar
            if (userId == 0)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
    }
}