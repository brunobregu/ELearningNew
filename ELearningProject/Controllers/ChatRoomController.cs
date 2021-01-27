using ELearningProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using ELearningProject.ViewModel;

namespace ELearningProject.Controllers
{
    public class ChatRoomController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();


        // GET: ChatRoom
        public ActionResult Index()
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            //Useri nuk eshte loguar
            if (userId == 0)
            {
                return RedirectToAction("Login", "User");
            }
            var comments = db.Comment.Include(x => x.Replies).OrderByDescending(x => x.CreatedOn).ToList();

            return View(comments);
        }



        //PostReply
        [HttpPost]
        public ActionResult PostReply(ReplyVM obj)
        {
            int userId = Convert.ToInt32(Session["UserId"]);

            //Textbox i reply eshte bosh
            if (string.IsNullOrEmpty(obj.Reply))
            {
                return RedirectToAction("Index");
            }

            //Shtimi i reply
            Reply r = new Reply();
            r.Text = obj.Reply;
            r.CommentId = obj.CID;
            r.UserId = userId;
            r.CreatedOn = DateTime.Now;
            db.Reply.Add(r);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        //PostComment
        [HttpPost]
        public ActionResult PostComment(string CommentText)
        {
            int userId = Convert.ToInt32(Session["UserId"]);

            //Komenti eshte bosh
            if (string.IsNullOrEmpty(CommentText))
            {
                return RedirectToAction("Index");
            }


            //Shtimi komentit
            Comment c = new Comment();
            c.Text = CommentText;
            c.CreatedOn = DateTime.Now;
            c.UserId = userId;
            db.Comment.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteComment(int id)
        {
            Comment comment = db.Comment.Find(id);
            db.Comment.Remove(comment);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult DeleteConfirm(int id)
        {
            Reply reply = db.Reply.Find(id);
            db.Reply.Remove(reply);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}