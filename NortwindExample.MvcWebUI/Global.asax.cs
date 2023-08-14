using NortwindExample.Entities;
using NortwindExample.MvcWebUI.Infrastructure;
using NortwindExample.MvcWebUI.ModelBinders;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace NortwindExample.MvcWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ControllerBuilder.Current.SetControllerFactory(new NincjectControllerFactory());

            System.Web.Mvc.ModelBinders.Binders.Add(typeof(Cart),new CartModelBinder());

        }
    }
}
