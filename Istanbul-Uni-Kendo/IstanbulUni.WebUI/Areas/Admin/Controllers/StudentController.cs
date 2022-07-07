using IstanbulUniKendo.BAL.Concrate;
using IstanbulUniKendo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IstanbulUniKendo.WebUI.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        StudentManager sm = new StudentManager();
        // GET: Admin/Student
        public ActionResult Index()
        {
            return View();
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