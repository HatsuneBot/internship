using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;

namespace EditApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Upload()
        {
            var upload = Request.Files[0];
            string fileName = System.IO.Path.GetFileName(upload.FileName);
            upload.SaveAs(Server.MapPath("~/Files/" + fileName));
            string text = System.IO.File.ReadAllText(Server.MapPath("~/Files/" + fileName));
            return Json(text);
        }

        public ActionResult UpdateContent(string fileContent, string fileName)
        {
            System.IO.File.WriteAllText(Server.MapPath("~/Files/" + fileName), fileContent);
            return Json(new { success = true, fileName }, JsonRequestBehavior.AllowGet);
        }

        public FileResult Download(string fileName)
        {
            var filepath = System.IO.Path.Combine(Server.MapPath("/Files/"), fileName);
            return File(filepath, MimeMapping.GetMimeMapping(filepath), fileName);
        }

    }
}