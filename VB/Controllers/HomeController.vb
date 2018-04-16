Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace MVCViewerWidgetDemo.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace
