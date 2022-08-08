using IstanbulUniKendo.BAL.Concrate;
using IstanbulUniKendo.DAL.EntityFramework;
using IstanbulUniKendo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace IstanbulUniKendo.WebUI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());
        // GET: Admin/Login
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public JsonResult Index(User user)
        {
            bool userVarMi = um.UserLogin(user);


            if (userVarMi)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                Session["UserName"] = user.UserName;
               
                //return RedirectToAction("Index", "Student");
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                ViewBag.durum = 0;
                //return RedirectToAction("Index", "Login");
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
       
     
        public ActionResult Logout()
        {
            Session.RemoveAll();
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Login");
        }
    }
}