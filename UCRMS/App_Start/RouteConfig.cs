﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UCRMS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Department",
                url: "{controller}/{action}",
                defaults: new { controller = "Department", action = "ViewAll" }
            );

            routes.MapRoute(
                name: "Student",
                url: "{controller}/{action}/{regNo}",
                defaults: new { controller = "Student", action = "ViewDetails", regNo="" }
            );
        }
    }
}
