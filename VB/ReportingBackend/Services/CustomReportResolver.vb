Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web.WebDocumentViewer

Namespace ReportingBackend.Services
    Friend Class ReportInfo
        Public Property DisplayName() As String
        Public Property GetReport() As Func(Of XtraReport)
    End Class
    Public Class CustomReportResolver
        Implements IWebDocumentViewerReportResolver

        Private reports As New Dictionary(Of String, ReportInfo)()

        Public Sub New()
            reports.Add("ordersReport", New ReportInfo With {.DisplayName = "Orders Report", .GetReport = Function() New OrdersReport()})
            reports.Add("categoriesReport", New ReportInfo With {.DisplayName = "Categories Report", .GetReport = Function() New CategoriesReport()})
            reports.Add("shapeReport", New ReportInfo With {.DisplayName = "Shapes Report", .GetReport = Function() New ShapeReport()})
        End Sub

        Private Function IWebDocumentViewerReportResolver_Resolve(ByVal reportEntry As String) As XtraReport Implements IWebDocumentViewerReportResolver.Resolve
            Dim reportInfo As ReportInfo = Nothing
            If (Not String.IsNullOrEmpty(reportEntry)) AndAlso reports.TryGetValue(reportEntry, reportInfo) Then
                Return reportInfo.GetReport.Invoke()
            End If
            Return Nothing
        End Function

        ' Get the list of available reports from the server.
        Public Function GetAvailableReports() As Dictionary(Of String, String)
            Return reports.ToDictionary(Function(r) r.Key, Function(r) r.Value.DisplayName)
        End Function


    End Class
End Namespace