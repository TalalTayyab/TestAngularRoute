using System;
using System.Web.Routing;
using System.Web.Mvc;


namespace TestAngularRoute
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteCollection routes = RouteTable.Routes;
            routes.MapRoute(
                 name: "Default",
                 url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Page", action = "Page_1", id = UrlParameter.Optional }
             );

        }
                
    }
}