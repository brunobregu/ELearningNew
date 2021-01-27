using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult SqlQuiz()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult SqlQuiz(FormCollection frm)
        {
            int sasia = 0;

            string pyetja1 = frm["Pyetja1"].ToString();
            string pyetja2 = frm["Pyetja2"].ToString();
            string pyetja3 = frm["Pyetja3"].ToString();
            string pyetja4 = frm["Pyetja4"].ToString();
            string pyetja5 = frm["Pyetja5"].ToString();
            string pyetja6 = frm["Pyetja6"].ToString();
            string pyetja7 = frm["Pyetja7"].ToString();
            string pyetja8 = frm["Pyetja8"].ToString();
            string pyetja9 = frm["Pyetja9"].ToString();
            string pyetja10 = frm["Pyetja10"].ToString();
            string pyetja11 = frm["Pyetja11"].ToString();
            string pyetja12 = frm["Pyetja12"].ToString();
            string pyetja13 = frm["Pyetja13"].ToString();
            string pyetja14 = frm["Pyetja14"].ToString();
            string pyetja15 = frm["Pyetja15"].ToString();
            string pyetja16 = frm["Pyetja16"].ToString();
            string pyetja17 = frm["Pyetja17"].ToString();
            string pyetja18 = frm["Pyetja18"].ToString();
            string pyetja19 = frm["Pyetja19"].ToString();
            string pyetja20 = frm["Pyetja20"].ToString();
            string pyetja21 = frm["Pyetja21"].ToString();
            string pyetja22 = frm["Pyetja22"].ToString();
            string pyetja23 = frm["Pyetja23"].ToString();
            string pyetja24 = frm["Pyetja24"].ToString();
            string pyetja25 = frm["Pyetja25"].ToString();

            if (pyetja1 == "Structured Query Language")
            {
                sasia += 2;
            }
            if (pyetja2 == "select")
            {
                sasia += 2;
            }
            if (pyetja3 == "update")
            {
                sasia += 2;
            }
            if (pyetja4 == "delete")
            {
                sasia += 2;
            }
            if (pyetja5 == "insert into")
            {
                sasia += 2;
            }
            if (pyetja6 == "select Emri from Person")
            {
                sasia += 2;
            }
            if (pyetja7 == "select * from Person")
            {
                sasia += 2;
            }
            if (pyetja8 == "select * from Person where Emri = 'Andi'")
            {
                sasia += 2;
            }
            if (pyetja9 == "select * from Person where Emri Like 'A%'")
            {
                sasia += 2;
            }
            if (pyetja10 == "E vertete")
            {
                sasia += 2;
            }
            if (pyetja11 == "select * from Person where Emri Between 'Bruno' And 'Kledis'")
            {
                sasia += 2;
            }
            if (pyetja12 == "select distinct")
            {
                sasia += 2;
            }
            if (pyetja13 == "order by")
            {
                sasia += 2;
            }
            if (pyetja14 == "order by")
            {
                sasia += 2;
            }
            if (pyetja15 == "select * from Person order by Emri DESC")
            {
                sasia += 2;
            }
            if (pyetja16 == "nsert into Person values('Bruno', 'Bregu')")
            {
                sasia += 2;
            }
            if (pyetja17 == "insert into Person(Mbiemer) values ('Hoxha')")
            {
                sasia += 2;
            }
            if (pyetja18 == "update Person set Mbiemri ='Hoxha' into Mbiemri = 'Bregu'")
            {
                sasia += 2;
            }
            if (pyetja19 == "delete from Person where Emri = 'Bruno'")
            {
                sasia += 2;
            }
            if (pyetja20 == "select  count(*) from Person")
            {
                sasia += 2;
            }
            if (pyetja21 == "inner join")
            {
                sasia += 2;
            }
            if (pyetja22 == "between")
            {
                sasia += 2;
            }
            if (pyetja23 == "E vertete")
            {
                sasia += 2;
            }
            if (pyetja24 == "like")
            {
                sasia += 2;
            }
            if (pyetja25 == "create table Person")
            {
                sasia += 2;
            }
            if (sasia <= 20)
            {
                return RedirectToAction("Fillestar", "Sql");
            }
            else if (sasia > 20 && sasia <= 36)
            {
                return RedirectToAction("Fillestar", "Sql");
            }
            else if (sasia > 36 && sasia <= 50)
            {
                return RedirectToAction("Fillestar", "Sql");
            }

            return Content("Dicka shkoi gabim");

        }


        public ActionResult MVCQuiz()
        {
           
            return View();
        }



        [HttpPost]
        public ActionResult MVCQuiz(FormCollection frm)
        {
            int sasia = 0;

            string pyetja1 = frm["Pyetja1"].ToString();
            string pyetja2 = frm["Pyetja2"].ToString();
            string pyetja3 = frm["Pyetja3"].ToString();
            string pyetja4 = frm["Pyetja4"].ToString();
            string pyetja5 = frm["Pyetja5"].ToString();
            string pyetja6 = frm["Pyetja6"].ToString();
            string pyetja7 = frm["Pyetja7"].ToString();
            string pyetja8 = frm["Pyetja8"].ToString();
            string pyetja9 = frm["Pyetja9"].ToString();
            string pyetja10 = frm["Pyetja10"].ToString();
            string pyetja11 = frm["Pyetja11"].ToString();
            string pyetja12 = frm["Pyetja12"].ToString();
            string pyetja13 = frm["Pyetja13"].ToString();
            string pyetja14 = frm["Pyetja14"].ToString();
            string pyetja15 = frm["Pyetja15"].ToString();
            string pyetja16 = frm["Pyetja16"].ToString();
            string pyetja17 = frm["Pyetja17"].ToString();
            string pyetja18 = frm["Pyetja18"].ToString();
            string pyetja19 = frm["Pyetja19"].ToString();
            string pyetja20 = frm["Pyetja20"].ToString();
            string pyetja21 = frm["Pyetja21"].ToString();
            string pyetja22 = frm["Pyetja22"].ToString();
            string pyetja23 = frm["Pyetja23"].ToString();
            string pyetja24 = frm["Pyetja24"].ToString();
            string pyetja25 = frm["Pyetja25"].ToString();

            if (pyetja1 == "Model View Controller")
            {
                sasia += 2;
            }
            if (pyetja2 == "Content")
            {
                sasia += 2;
            }
            if (pyetja3 == "ViewBag.Afisho")
            {
                sasia += 2;
            }
            if (pyetja4 == "te dyja")
            {
                sasia += 2;
            }
            if (pyetja5 == "string")
            {
                sasia += 2;
            }
            if (pyetja6 == "TextBoxFor")
            {
                sasia += 2;
            }
            if (pyetja7 == "CheckBoxFor")
            {
                sasia += 2;
            }
            if (pyetja8 == "HiddenFor")
            {
                sasia += 2;
            }
            if (pyetja9 == "ActionLink")
            {
                sasia += 2;
            }
            if (pyetja10 == "_Menu")
            {
                sasia += 2;
            }
            if (pyetja11 == ".cs")
            {
                sasia += 2;
            }
            if (pyetja12 == ".cshtml")
            {
                sasia += 2;
            }
            if (pyetja13 == "Required")
            {
                sasia += 2;
            }
            if (pyetja14 == "RegularExpression")
            {
                sasia += 2;
            }
            if (pyetja15 == "Language Integrated Query")
            {
                sasia += 2;
            }
            if (pyetja16 == "2")
            {
                sasia += 2;
            }
            if (pyetja17 == "OrderBy")
            {
                sasia += 2;
            }
            if (pyetja18 == "Reverse")
            {
                sasia += 2;
            }
            if (pyetja19 == "Distinct")
            {
                sasia += 2;
            }
            if (pyetja20 == "Where")
            {
                sasia += 2;
            }
            if (pyetja21 == "Select")
            {
                sasia += 2;
            }
            if (pyetja22 == "Select")
            {
                sasia += 2;
            }
            if (pyetja23 == "Code-First")
            {
                sasia += 2;
            }
            if (pyetja24 == "add-migration")
            {
                sasia += 2;
            }
            if (pyetja25 == "ElementAt")
            {
                sasia += 2;
            }
            if (sasia <= 20)
            {
                return RedirectToAction("Fillestar", "MVC");
            }
            else if (sasia > 20 && sasia <= 36)
            {
                return RedirectToAction("Mesatar", "MVC");
            }
            else if (sasia > 36 && sasia <= 50)
            {
                return RedirectToAction("Avancuar", "MVC");
            }
            return Content("Dicka shkoi gabim");

        }


        public ActionResult JavaQuiz()
        {
            
            return View();
        }



        [HttpPost]
        public ActionResult JavaQuiz(FormCollection frm)
        {
            int sasia = 0;

            string pyetja1 = frm["Pyetja1"].ToString();
            string pyetja2 = frm["Pyetja2"].ToString();
            string pyetja3 = frm["Pyetja3"].ToString();
            string pyetja4 = frm["Pyetja4"].ToString();
            string pyetja5 = frm["Pyetja5"].ToString();
            string pyetja6 = frm["Pyetja6"].ToString();
            string pyetja7 = frm["Pyetja7"].ToString();
            string pyetja8 = frm["Pyetja8"].ToString();
            string pyetja9 = frm["Pyetja9"].ToString();
            string pyetja10 = frm["Pyetja10"].ToString();
            string pyetja11 = frm["Pyetja11"].ToString();
            string pyetja12 = frm["Pyetja12"].ToString();
            string pyetja13 = frm["Pyetja13"].ToString();
            string pyetja14 = frm["Pyetja14"].ToString();
            string pyetja15 = frm["Pyetja15"].ToString();
            string pyetja16 = frm["Pyetja16"].ToString();
            string pyetja17 = frm["Pyetja17"].ToString();
            string pyetja18 = frm["Pyetja18"].ToString();
            string pyetja19 = frm["Pyetja19"].ToString();
            string pyetja20 = frm["Pyetja20"].ToString();
            string pyetja21 = frm["Pyetja21"].ToString();
            string pyetja22 = frm["Pyetja22"].ToString();
            string pyetja23 = frm["Pyetja23"].ToString();
            string pyetja24 = frm["Pyetja24"].ToString();
            string pyetja25 = frm["Pyetja25"].ToString();

            if (pyetja1 == "System.out.println(“Hello World”);")
            {
                sasia += 2;
            }
            if (pyetja2 == "E vertete")
            {
                sasia += 2;
            }
            if (pyetja3 == "// This is a comment")
            {
                sasia += 2;
            }
            if (pyetja4 == "String")
            {
                sasia += 2;
            }
            if (pyetja5 == "int x = 5;")
            {
                sasia += 2;
            }
            if (pyetja6 == "float x = 2.8f;")
            {
                sasia += 2;
            }
            if (pyetja7 == "Length()")
            {
                sasia += 2;
            }
            if (pyetja8 == "+")
            {
                sasia += 2;
            }
            if (pyetja9 == "E gabuar")
            {
                sasia += 2;
            }
            if (pyetja10 == "toUpperCase()")
            {
                sasia += 2;
            }
            if (pyetja11 == "==")
            {
                sasia += 2;
            }
            if (pyetja12 == "[]")
            {
                sasia += 2;
            }
            if (pyetja13 == "0")
            {
                sasia += 2;
            }
            if (pyetja14 == "methodName()")
            {
                sasia += 2;
            }
            if (pyetja15 == "methodName()")
            {
                sasia += 2;
            }
            if (pyetja16 == "class")
            {
                sasia += 2;
            }
            if (pyetja17 == "MyClass myObj = new MyClass();")
            {
                sasia += 2;
            }
            if (pyetja18 == "E vertete")
            {
                sasia += 2;
            }
            if (pyetja19 == "Math.max(x,y)")
            {
                sasia += 2;
            }
            if (pyetja20 == "Import")
            {
                sasia += 2;
            }
            if (pyetja21 == "*")
            {
                sasia += 2;
            }
            if (pyetja22 == "If (x > y)")
            {
                sasia += 2;
            }
            if (pyetja23 == "While (x > y)")
            {
                sasia += 2;
            }
            if (pyetja24 == "return")
            {
                sasia += 2;
            }
            if (pyetja25 == "break")
            {
                sasia += 2;
            }
            if (sasia <= 20)
            {
                return RedirectToAction("Fillestar", "Java");
            }
            else if (sasia > 20 && sasia <= 36)
            {
                return RedirectToAction("Mesatar", "Java");
            }
            else if (sasia > 36 && sasia <= 50)
            {
                return RedirectToAction("Avancuar", "Java");
            }

            return Content("Dicka shkoi gabim");

        }
    }
}