using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace practical09
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Web Forms project: no MVC default route, so Default.aspx opens at "/"
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
        }
    }
}