using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClockApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult SendMessage(int time, string message)
        {
            Timer newEvent = new Timer();
            Message msg = new Message();

            msg.onSleep += newEvent.Sleep;
            string result = msg.NewMessage(time, message);
            msg.onSleep -= newEvent.Sleep;

            return Json(new { success = true,result}, JsonRequestBehavior.AllowGet);
        }

    }
}