Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Http
Imports System.Web.Http.Controllers
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace MVCViewerWidgetDemo
    Public Class RouteConfig
        Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

            routes.MapRoute(name:= "Default", url:= "{controller}/{action}/{id}", defaults:= New With {Key .controller = "Home", Key .action = "Index", Key .id = RouteParameter.Optional})
                'namespaces: new[] { "DevExpress.Web.Mvc.Controllers" },
        End Sub
    End Class
End Namespace