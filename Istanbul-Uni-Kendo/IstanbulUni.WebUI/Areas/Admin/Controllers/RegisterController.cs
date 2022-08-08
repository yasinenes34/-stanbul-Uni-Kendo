using IstanbulUniKendo.BAL.Concrate;
using IstanbulUniKendo.DAL.EntityFramework;
using IstanbulUniKendo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IstanbulUniKendo.WebUI.Areas.Admin.Controllers
{
    public class RegisterController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());
        // GET: Admin/Regist
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
                return Json(false, JsonRequestBehavior.AllowGet); 
            }
            else
            {
                um.UserAddBl(user);
                return Json(true, JsonRequestBehavior.AllowGet);
               
            }


           
        }
    }
}