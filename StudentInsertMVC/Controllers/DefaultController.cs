using StudentInsertMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInsertMVC.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult ShowStudent()
        {
            tblStudent s1 = new tblStudent() { Id = 1 ,name="rajesh"};
           
            return View(s1);
        }
        // GET: Default
        public ActionResult Index()
        {
            Session["user"] = "abc";
            Session.Timeout = 10;
            return View();
        }
        public ActionResult SelectCourse()
        {
            List<Course> clist = new List<Course>() {
            new Course(){Id=1,name="MCA"},
            new Course(){Id=2,name="MBA"},
            new Course(){Id=3,name="Engg"},
            };
            CourseList clistobj = new CourseList();
            clistobj.coursesList = clist;
            clistobj.SelectedCourse = "";
            return View(clistobj);
        }
        [HttpPost]
        public ActionResult SelectCourse(CourseList cl)
        {
            return View(cl);
        }
            public ActionResult Login()
        {
            return View();
            //// return View("ShowStudent");
            //return RedirectToAction("ShowStudent");
        }
        [HttpPost]
        public ActionResult Login(string Hindi,String Marathi,string English,string gender)
        {
           
            return View();
            //// return View("ShowStudent");
            //return RedirectToAction("ShowStudent");
        }
        public ActionResult LoginFor()
        {
            
            return View();
           
        }
        [HttpPost]
        public ActionResult LoginFor(Lang lg)
        {
            if (lg.marathi==true)
            {
                //logic for marathi language
            }
            return View();
            //// return View("ShowStudent");
            //return RedirectToAction("ShowStudent");
        }

        public ActionResult Singup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Singup(tblStudent st)
        {
            return View();
        }

    }
}