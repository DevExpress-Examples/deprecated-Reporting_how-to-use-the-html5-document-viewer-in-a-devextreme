Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web.WebDocumentViewer.Native.Services

Namespace MVCViewerWidgetDemo.Models
    Public Class CustomReportResolver
        Inherits WebDocumentViewerReportResolver

        Public Overrides Function Resolve(ByVal reportTypeName As String) As XtraReport
            Dim report = MyBase.Resolve(reportTypeName)
            If report Is Nothing Then
                Select Case reportTypeName
                    Case "MVCViewerWidgetDemo.Reports.OrdersReport"
                        report = New Reports.OrdersReport()
                    Case "MVCViewerWidgetDemo.Reports.ProductsReport"
                        report = New Reports.ProductsReport()
                End Select
            End If
            Return report
        End Function
    End Class
End Namespace