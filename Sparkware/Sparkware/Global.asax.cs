using Microsoft.Practices.Unity;
using Sparkware.App_Start;
using Sparkware.Models;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Sparkware {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            var unityContainer = new UnityContainer();
            UnityConfig.RegisterTypes(unityContainer);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ModelBinders.Binders.DefaultBinder = new UserModelBinder();
        }
    }
}