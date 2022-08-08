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
using IstanbulUni.WebUI.Models;

namespace IstanbulUniKendo.WebUI.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        StudentManager sm = new StudentManager(new EfStudentDal());
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult EditingInline_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(sm.GetListBl().ToDataSourceResult(request));
        }
        
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Create([DataSourceRequest] DataSourceRequest request, Student student)
        {
            if (student != null && ModelState.IsValid)
            {
                sm.StudentAddBl(student);
            }

            return Json(new[] { student }.ToDataSourceResult(request, ModelState));
        }
       
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Update([DataSourceRequest] DataSourceRequest request, Student student)
        {
            if (student != null && ModelState.IsValid)
            {
                sm.StudentUpdateBl(student);
            }

            return Json(new[] { student }.ToDataSourceResult(request, ModelState));
        }

        
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Destroy([DataSourceRequest] DataSourceRequest request, Student student)
        {
            if (student != null)
            {
                sm.StudentRemoveBl(student);
            }

            return Json(new[] { student }.ToDataSourceResult(request, ModelState));
        }

    }
}