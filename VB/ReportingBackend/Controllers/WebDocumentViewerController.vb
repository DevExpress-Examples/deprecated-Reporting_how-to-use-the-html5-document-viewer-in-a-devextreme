Imports System.Linq
Imports System.Web.Mvc
Imports System.Web.Routing
Imports DevExpress.Web.Mvc.Controllers
Imports ReportingBackend.Services

Namespace ReportingBackend.Controllers
    Public Class WebDocumentViewerController
        Inherits WebDocumentViewerApiController

        #Region "WebDocumentViewer Overrides"
        ' This action processes each request from the Web Document Viewer.
        Public Overrides Function Invoke() As ActionResult
            Response.AddHeader("Access-Control-Allow-Origin", "*") ' Allow cross-domain requests.
            Return MyBase.Invoke()
        End Function
        #End Region

        ' Create an action to provide the Web Document Viewer with available reports.
        Public Function GetReportList() As ActionResult
            Dim reports = (New CustomReportResolver()).GetAvailableReports().ToArray()
            Response.AddHeader("Access-Control-Allow-Origin", "*") ' Allow cross-domain requests.
            Return New JsonResult() With {.ContentType = "application/json", .Data = reports}
        End Function
    End Class
End Namespace