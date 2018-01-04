using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebForYouUI.Models;

namespace WebForYouUI
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //DebugDb.TestDb();
        }
    }
}
