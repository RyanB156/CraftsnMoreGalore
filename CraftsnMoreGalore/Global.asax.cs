using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Newtonsoft.Json;
using CraftsnMoreGalore.Models;

namespace CraftsnMoreGalore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var s = JsonConvert.DeserializeObject<Secret>(File.ReadAllText("~/Content/secret.json"));

            Environment.SetEnvironmentVariable("MJ_APIKEY_PUBLIC", s.MJ_APIKEY_PUBLIC);
            Environment.SetEnvironmentVariable("MJ_APIKEY_PRIVATE", s.MJ_APIKEY_PRIVATE);
        }
    }
}
