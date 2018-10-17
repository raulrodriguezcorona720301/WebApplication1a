using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                null,
                "",
                new { controller="Inicio", action = "Index" }
            );

            routes.MapRoute(
                null,
                "Login",
                new { controller ="Login", action="Index"}
            );

            routes.MapRoute(
                null,
                "Login/Index",
                new { controller = "Login", action = "Index" }
            );

            routes.MapRoute(
                null,
                "SaveProduct",
                new { controller="Product", action="SaveProduct"}
            );

            routes.MapRoute(
                null,
                "{guidId}",
                new { controller = "Product", action= "EditProductById"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
