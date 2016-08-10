using BinTreeApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BinTreeApplication.Controllers
{
    public class HomeController : Controller
    {
        public BTree t = new BTree();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddStudent(string name, string testName, string date, int rating)
        {
            Student value = new Student(name, testName, date, rating);
            t.Insert(value);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
    }
}