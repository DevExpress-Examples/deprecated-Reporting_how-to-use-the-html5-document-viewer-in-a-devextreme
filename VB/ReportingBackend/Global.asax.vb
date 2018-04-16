Imports System.Web.Mvc
Imports System.Web.Routing
Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports ReportingBackend.Services

Namespace ReportingBackend
    Public Class MvcApplication
        Inherits System.Web.HttpApplication

        Protected Sub Application_Start()
            AreaRegistration.RegisterAllAreas()
            RouteConfig.RegisterRoutes(RouteTable.Routes)
            DefaultWebDocumentViewerContainer.Register(Of IWebDocumentViewerReportResolver, CustomReportResolver)()
        End Sub
    End Class
End Namespace
