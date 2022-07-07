using IstanbulUniKendo.BAL.Concrate;
using IstanbulUniKendo.DAL.EntityFramework;
using IstanbulUniKendo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;   
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;



namespace IstanbulUniKendo.WebUI.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        StudentManager sm = new StudentManager(new EfStudentDal());
       
        // GET: Admin/Student
        public ActionResult Index()
        {
            var StudnetList = sm.GetListBl();
            return View(StudnetList);
        }
        [HttpPost]
        public ActionResult StudentAdd(Student student)
        {
            sm.StudentAddBl(student);
            return RedirectToAction("StudentList");
           
        }


        public ActionResult StudentList([DataSourceRequest] DataSourceRequest request)
        {
            return Json(sm.GetListBl().ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult StudentUpdate([DataSourceRequest] DataSourceRequest request, Student student)
        {
            
            if (student != null && ModelState.IsValid)
            {
                sm.StudentUpdateBl(student);
            }

            return Json(new[] { student }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult StudentDelete([DataSourceRequest] DataSourceRequest request, Student student)
        {
            if (student != null)
            {
                
                sm.StudentRemoveBl(student);
            }

            return Json(new[] { student }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }



    }
}