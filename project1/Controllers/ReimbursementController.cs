using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project1.Models;
namespace project1.Controllers
{
    public class ReimbursementController : Controller
    {
        // GET: Reimbursement
        private project1Entities p = new project1Entities();
        public ActionResult reimburse()
        {
            return View();
        }
        [HttpPost]
        public ActionResult reimburse(reimburse r)
        {
            p.reimburses.Add(r);
            p.SaveChanges();
            ViewBag.Message = "Data insert successfully";
            return View();

        }



        [Authorize(Roles = "Manager")]
        //leave list
        public ActionResult reimburselist()
        {
            project1Entities p = new project1Entities();
            List<reimburse> r = p.reimburses.ToList();
            return View(r);
        }


        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/uploads"), _FileName);
                    file.SaveAs(_path);
                }
                ViewBag.Message = "File Uploaded Successfully!!";
                return View();
            }
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }
        }

    }
}