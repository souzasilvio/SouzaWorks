using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Crm.Portal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //void Application_AuthenticateRequest(object sender, EventArgs e)
        //{
        //   this.Context.User = UsuarioTeste;
        //}

        //private static IPrincipal UsuarioTeste
        //{
        //    get
        //    {
        //        IIdentity identity = new GenericIdentity("Silvio Souza");
        //        string[] roles = { "Administrador", "Corretor" };
        //        return new GenericPrincipal(identity, roles);
        //    }
        //}
    }
}
