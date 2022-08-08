using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IstanbulUni.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                    name: "Login",
                    url: "",
                    defaults: new { controller = "Admin/Login", action = "Index", id = UrlParameter.Optional }
                );
        }
    }
}
