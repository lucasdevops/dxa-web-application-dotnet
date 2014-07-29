﻿using System.Web.Mvc;

namespace Sdl.Web.Site.Areas.Core
{
    public class CoreAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Core";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //Google Site Map
            context.MapRoute(
                "Core_Sitemap_Xml",
                "sitemap.xml",
                new { controller = "Navigation", action = "SiteMap" }
            );

            //For resolving ids to urls
            context.MapRoute(
               "Core_Resolve",
               "resolve/{*itemId}",
               new { controller = "Page", action = "Resolve" },
               new { itemId = @"^(.*)?$" }
            );

            //Tridion Page Route
            context.MapRoute(
               "Core_Page",
               "{*pageUrl}",
               new { controller = "Page", action = "Page" },
               new { pageId = @"^(.*)?$" }
            );
            
            //Default Route - required for sub actions (region/entity/navigation etc.)
            context.MapRoute(
                "Core_Default", 
                "{controller}/{action}/{id}", 
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}