using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using DevExpress.XtraReports.Web;

namespace MVCViewerWidgetDemo {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //var corsAttr = new EnableCorsAttribute("http://localhost:55777", "*", "*");
            //config.EnableCors(corsAttr);

            var a = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            a.UseDataContractJsonSerializer = true;
        }
    }
}
