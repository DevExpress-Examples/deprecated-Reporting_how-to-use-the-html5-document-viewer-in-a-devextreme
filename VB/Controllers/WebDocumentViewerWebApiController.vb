Imports System.Web.Http
Imports DevExpress.Web.Mvc
Imports DevExpress.XtraReports.Web.Native.ClientControls
Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports DevExpress.XtraReports.Web.WebDocumentViewer.Native.Services

Namespace MVCViewerWidgetDemo.Controllers
    Public Class WebDocumentViewerWebApiController
        Inherits ApiController

        Private ReadOnly requestProcessor As ManagerModuleSubscriber(Of IWebDocumentViewerRequestManager)

        Public Sub New()
            requestProcessor = New ManagerModuleSubscriber(Of IWebDocumentViewerRequestManager)(DefaultWebDocumentViewerContainer.Current, "")
        End Sub

        Public Sub [Get]()
            System.Web.HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Origin", "*")
            requestProcessor.ProcessRequest()
        End Sub

        Public Sub Post()
            System.Web.HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Origin", "*")
            requestProcessor.ProcessRequest()
        End Sub
    End Class
End Namespace