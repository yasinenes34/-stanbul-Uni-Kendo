using IstanbulUniKendo.BAL.Concrate;
using IstanbulUniKendo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.UI;


namespace IstanbulUniKendo.WebUI.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        StudentManager sm = new StudentManager();
        // GET: Admin/Student
        public ActionResult Index()
        {
            //var studentlist = sm.GetListBl();
            return View(/*studentlist*/);
        }
        public ActionResult StudentAdd()
        {
           Student student = new Student();
            return View(student);
        }
        [HttpPost]
        public ActionResult StudentAdd(Student student)
        {
            sm.StudentAddBl(student);
            return View();
        }
    }
}