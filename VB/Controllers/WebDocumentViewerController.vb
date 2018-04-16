Imports System.Web.Mvc
Imports DevExpress.Web.Mvc.Controllers

Namespace MVCViewerWidgetDemo.Controllers
    Public Class WebDocumentViewerController
        Inherits WebDocumentViewerApiController

        Public Function CustomInvoke() As ActionResult
            Dim result = MyBase.Invoke()
            Response.AppendHeader("Access-Control-Allow-Origin", "*")
            Return result
        End Function
    End Class
End Namespace