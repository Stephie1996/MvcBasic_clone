using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcBasic_clone
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "MacRout",
               url: "Mac",
               defaults: new { controller = "Mac", action = "MacPage", id = UrlParameter.Optional }
             );

            routes.MapRoute(
               name: "WatchRout",
               url: "Watch",
               defaults: new { controller = "Watch", action = "WatchPage", id = UrlParameter.Optional }
             );

            routes.MapRoute(
               name: "iPhoneRout",
               url: "iPhone",
               defaults: new { controller = "iPhone", action = "iPhonePage", id = UrlParameter.Optional }
             );

            routes.MapRoute(
               name: "iPadRout",
               url: "iPad",
               defaults: new { controller = "iPad", action = "iPadPage", id = UrlParameter.Optional }
             );

            routes.MapRoute(
              name: "EmployeeRout",
              url: "MyEmployee",
              defaults: new { controller = "Employees", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
             name: "FriendsRout",
             url: "MyFriends",
             defaults: new { controller = "Friends", action = "Index", id = UrlParameter.Optional }
           );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
