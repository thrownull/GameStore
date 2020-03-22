﻿using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using GameStore.Domain.Entities;
using GameStore.WebUI.App_Start;
using GameStore.WebUI.Infrastructure.Binders;

namespace GameStore.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
            BundleConfig.RegisterBoundles(BundleTable.Bundles);
        }
    }
}