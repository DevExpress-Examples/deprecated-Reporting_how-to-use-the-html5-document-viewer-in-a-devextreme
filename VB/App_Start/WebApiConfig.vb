Imports System
Imports System.Linq
Imports System.Web.Http
Imports System.Web.Http.Controllers
Imports System.Web.Http.Dispatcher
Imports DevExpress.XtraReports.Web

Namespace MVCViewerWidgetDemo
    Public NotInheritable Class WebApiConfig

        Private Sub New()
        End Sub

        Public Shared Sub Register(ByVal config As HttpConfiguration)

            config.Routes.MapHttpRoute(name:= "DefaultApi", routeTemplate:= "api/{controller}/{id}", defaults:= New With {Key .id = RouteParameter.Optional})

            'var corsAttr = new EnableCorsAttribute("http://localhost:55777", "*", "*");
            'config.EnableCors(corsAttr);

            Dim a = GlobalConfiguration.Configuration.Formatters.JsonFormatter
            a.UseDataContractJsonSerializer = True
        End Sub
    End Class
End Namespace
