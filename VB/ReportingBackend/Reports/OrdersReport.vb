Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for OrdersReport
''' </summary>
Public Class OrdersReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private Detail As DevExpress.XtraReports.UI.DetailBand
    Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Private xrTable2 As XRTable
    Private xrTableRow4 As XRTableRow
    Private xrTableCell9 As XRTableCell
    Private xrTableCell10 As XRTableCell
    Private xrTableCell11 As XRTableCell
    Private xrTableRow5 As XRTableRow
    Private xrTableCell12 As XRTableCell
    Private xrTableCell13 As XRTableCell
    Private xrTableCell14 As XRTableCell
    Private xrPageInfo1 As XRPageInfo
    Private xrPageInfo2 As XRPageInfo
    Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Private reportHeaderBand1 As ReportHeaderBand
    Private xrLabel1 As XRLabel
    Private groupHeaderBand1 As GroupHeaderBand
    Private xrTable1 As XRTable
    Private xrTableRow2 As XRTableRow
    Private xrTableCell4 As XRTableCell
    Private xrTableCell5 As XRTableCell
    Private xrTableRow1 As XRTableRow
    Private xrTableCell1 As XRTableCell
    Private xrTableCell2 As XRTableCell
    Private xrTableCell3 As XRTableCell
    Private xrTableRow3 As XRTableRow
    Private xrTableCell6 As XRTableCell
    Private xrTableCell7 As XRTableCell
    Private xrTableCell8 As XRTableCell
    Private detailReportBand1 As DetailReportBand
    Private groupHeaderBand2 As GroupHeaderBand
    Private xrPanel1 As XRPanel
    Private xrTable3 As XRTable
    Private xrTableRow7 As XRTableRow
    Private xrTableCell18 As XRTableCell
    Private xrTableCell19 As XRTableCell
    Private xrTableCell20 As XRTableCell
    Private detailBand1 As DetailBand
    Private xrTable4 As XRTable
    Private xrTableRow9 As XRTableRow
    Private xrTableCell24 As XRTableCell
    Private xrTableCell25 As XRTableCell
    Private xrTableCell26 As XRTableCell
    Private xrTableRow6 As XRTableRow
    Private xrTableCell15 As XRTableCell
    Private xrTableCell16 As XRTableCell
    Private xrTableCell17 As XRTableCell
    Private xrTableRow8 As XRTableRow
    Private xrTableCell21 As XRTableCell
    Private xrTableCell22 As XRTableCell
    Private xrTableCell23 As XRTableCell
    Private Title As XRControlStyle
    Private GroupCaption1 As XRControlStyle
    Private GroupData1 As XRControlStyle
    Private DetailCaption1 As XRControlStyle
    Private DetailData1 As XRControlStyle
    Private DetailCaption3 As XRControlStyle
    Private DetailData3 As XRControlStyle
    Private DetailData3_Odd As XRControlStyle
    Private DetailCaptionBackground3 As XRControlStyle
    Private PageInfo As XRControlStyle

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
        '
        ' TODO: Add constructor logic here
        '
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    #Region "Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim selectQuery2 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column6 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As New DevExpress.DataAccess.Sql.Table()
            Dim column7 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column12 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column13 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column14 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column15 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression15 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column16 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OrdersReport))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.detailReportBand1 = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable4 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupData1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaptionBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.Detail.HeightF = 56F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPageInfo2})
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "OrderID"
            table1.Name = "OrderDetails"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductID"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "UnitPrice"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Quantity"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Discount"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.MetaSerializable = "<Meta X=""130"" Y=""20"" Width=""100"" Height=""122"" />"
            selectQuery1.Name = "OrderDetails"
            selectQuery1.Tables.Add(table1)
            columnExpression6.ColumnName = "ProductID"
            table2.Name = "Products"
            columnExpression6.Table = table2
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "ProductName"
            columnExpression7.Table = table2
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "SupplierID"
            columnExpression8.Table = table2
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "CategoryID"
            columnExpression9.Table = table2
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "QuantityPerUnit"
            columnExpression10.Table = table2
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "UnitPrice"
            columnExpression11.Table = table2
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "UnitsInStock"
            columnExpression12.Table = table2
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "UnitsOnOrder"
            columnExpression13.Table = table2
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "ReorderLevel"
            columnExpression14.Table = table2
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "Discontinued"
            columnExpression15.Table = table2
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "EAN13"
            columnExpression16.Table = table2
            column16.Expression = columnExpression16
            selectQuery2.Columns.Add(column6)
            selectQuery2.Columns.Add(column7)
            selectQuery2.Columns.Add(column8)
            selectQuery2.Columns.Add(column9)
            selectQuery2.Columns.Add(column10)
            selectQuery2.Columns.Add(column11)
            selectQuery2.Columns.Add(column12)
            selectQuery2.Columns.Add(column13)
            selectQuery2.Columns.Add(column14)
            selectQuery2.Columns.Add(column15)
            selectQuery2.Columns.Add(column16)
            selectQuery2.MetaSerializable = "<Meta X=""10"" Y=""20"" Width=""100"" Height=""224"" />"
            selectQuery2.Name = "Products"
            selectQuery2.Tables.Add(table2)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1, selectQuery2})
            masterDetailInfo1.DetailQueryName = "Products"
            relationColumnInfo1.NestedKeyColumn = "ProductID"
            relationColumnInfo1.ParentKeyColumn = "ProductID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
            masterDetailInfo1.MasterQueryName = "OrderDetails"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() { masterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.xrPageInfo1.StyleName = "PageInfo"
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Format = "Page {0} of {1}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.xrPageInfo2.StyleName = "PageInfo"
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' reportHeaderBand1
            ' 
            Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.reportHeaderBand1.HeightF = 60F
            Me.reportHeaderBand1.Name = "reportHeaderBand1"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(638F, 26F)
            Me.xrLabel1.StyleName = "Title"
            Me.xrLabel1.Text = "Orders Report "
            ' 
            ' groupHeaderBand1
            ' 
            Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.groupHeaderBand1.HeightF = 25F
            Me.groupHeaderBand1.Name = "groupHeaderBand1"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 1R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 1R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.Weight = 1R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.StyleName = "GroupCaption1"
            Me.xrTableCell4.Text = "ORDER ID"
            Me.xrTableCell4.Weight = 0R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.OrderID")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.StyleName = "GroupData1"
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.Weight = 0R
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 0R
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow4, Me.xrTableRow5})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 56F)
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Weight = 1R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Text = "xrTableCell6"
            Me.xrTableCell6.Weight = 1R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Text = "xrTableCell7"
            Me.xrTableCell7.Weight = 1R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.Weight = 1R
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell9, Me.xrTableCell10, Me.xrTableCell11})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Weight = 0R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.StyleName = "DetailCaption1"
            Me.xrTableCell9.StylePriority.UseBorders = False
            Me.xrTableCell9.StylePriority.UseTextAlignment = False
            Me.xrTableCell9.Text = "Unit Price"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell9.Weight = 0R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.StyleName = "DetailCaption1"
            Me.xrTableCell10.StylePriority.UseTextAlignment = False
            Me.xrTableCell10.Text = "Quantity"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell10.Weight = 0R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.StyleName = "DetailCaption1"
            Me.xrTableCell11.StylePriority.UseTextAlignment = False
            Me.xrTableCell11.Text = "Discount"
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell11.Weight = 0R
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell12, Me.xrTableCell13, Me.xrTableCell14})
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Weight = 0R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.UnitPrice", "{0:C2}")})
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.StyleName = "DetailData1"
            Me.xrTableCell12.StylePriority.UseBorders = False
            Me.xrTableCell12.StylePriority.UseTextAlignment = False
            Me.xrTableCell12.Text = "xrTableCell12"
            Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell12.Weight = 0R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Quantity")})
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.StyleName = "DetailData1"
            Me.xrTableCell13.StylePriority.UseTextAlignment = False
            Me.xrTableCell13.Text = "xrTableCell13"
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell13.Weight = 0R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Discount", "{0:0.00%}")})
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.StyleName = "DetailData1"
            Me.xrTableCell14.StylePriority.UseTextAlignment = False
            Me.xrTableCell14.Text = "xrTableCell14"
            Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell14.Weight = 0R
            ' 
            ' detailReportBand1
            ' 
            Me.detailReportBand1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.groupHeaderBand2, Me.detailBand1})
            Me.detailReportBand1.DataMember = "OrderDetails.OrderDetailsProducts"
            Me.detailReportBand1.DataSource = Me.sqlDataSource1
            Me.detailReportBand1.Level = 0
            Me.detailReportBand1.Name = "detailReportBand1"
            ' 
            ' groupHeaderBand2
            ' 
            Me.groupHeaderBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanel1})
            Me.groupHeaderBand2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.groupHeaderBand2.HeightF = 48F
            Me.groupHeaderBand2.Name = "groupHeaderBand2"
            ' 
            ' xrPanel1
            ' 
            Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable3})
            Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPanel1.Name = "xrPanel1"
            Me.xrPanel1.SizeF = New System.Drawing.SizeF(650F, 48F)
            Me.xrPanel1.StyleName = "DetailCaptionBackground3"
            ' 
            ' xrTable3
            ' 
            Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 20F)
            Me.xrTable3.Name = "xrTable3"
            Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow7})
            Me.xrTable3.SizeF = New System.Drawing.SizeF(650F, 28F)
            ' 
            ' xrTableRow6
            ' 
            Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell15, Me.xrTableCell16, Me.xrTableCell17})
            Me.xrTableRow6.Name = "xrTableRow6"
            Me.xrTableRow6.Weight = 1R
            ' 
            ' xrTableCell15
            ' 
            Me.xrTableCell15.Name = "xrTableCell15"
            Me.xrTableCell15.Text = "xrTableCell15"
            Me.xrTableCell15.Weight = 1R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.Text = "xrTableCell16"
            Me.xrTableCell16.Weight = 1R
            ' 
            ' xrTableCell17
            ' 
            Me.xrTableCell17.Name = "xrTableCell17"
            Me.xrTableCell17.Text = "xrTableCell17"
            Me.xrTableCell17.Weight = 1R
            ' 
            ' xrTableRow7
            ' 
            Me.xrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell18, Me.xrTableCell19, Me.xrTableCell20})
            Me.xrTableRow7.Name = "xrTableRow7"
            Me.xrTableRow7.Weight = 0R
            ' 
            ' xrTableCell18
            ' 
            Me.xrTableCell18.Name = "xrTableCell18"
            Me.xrTableCell18.StyleName = "DetailCaption3"
            Me.xrTableCell18.Text = "Product Name"
            Me.xrTableCell18.Weight = 0R
            ' 
            ' xrTableCell19
            ' 
            Me.xrTableCell19.Name = "xrTableCell19"
            Me.xrTableCell19.StyleName = "DetailCaption3"
            Me.xrTableCell19.StylePriority.UseTextAlignment = False
            Me.xrTableCell19.Text = "Unit Price"
            Me.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell19.Weight = 0R
            ' 
            ' xrTableCell20
            ' 
            Me.xrTableCell20.Name = "xrTableCell20"
            Me.xrTableCell20.StyleName = "DetailCaption3"
            Me.xrTableCell20.StylePriority.UseTextAlignment = False
            Me.xrTableCell20.Text = "Units In Stock"
            Me.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell20.Weight = 0R
            ' 
            ' detailBand1
            ' 
            Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable4})
            Me.detailBand1.HeightF = 25F
            Me.detailBand1.Name = "detailBand1"
            ' 
            ' xrTable4
            ' 
            Me.xrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable4.Name = "xrTable4"
            Me.xrTable4.OddStyleName = "DetailData3_Odd"
            Me.xrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow9})
            Me.xrTable4.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' xrTableRow8
            ' 
            Me.xrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell21, Me.xrTableCell22, Me.xrTableCell23})
            Me.xrTableRow8.Name = "xrTableRow8"
            Me.xrTableRow8.Weight = 1R
            ' 
            ' xrTableCell21
            ' 
            Me.xrTableCell21.Name = "xrTableCell21"
            Me.xrTableCell21.Text = "xrTableCell21"
            Me.xrTableCell21.Weight = 1R
            ' 
            ' xrTableCell22
            ' 
            Me.xrTableCell22.Name = "xrTableCell22"
            Me.xrTableCell22.Text = "xrTableCell22"
            Me.xrTableCell22.Weight = 1R
            ' 
            ' xrTableCell23
            ' 
            Me.xrTableCell23.Name = "xrTableCell23"
            Me.xrTableCell23.Text = "xrTableCell23"
            Me.xrTableCell23.Weight = 1R
            ' 
            ' xrTableRow9
            ' 
            Me.xrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell24, Me.xrTableCell25, Me.xrTableCell26})
            Me.xrTableRow9.Name = "xrTableRow9"
            Me.xrTableRow9.Weight = 0R
            ' 
            ' xrTableCell24
            ' 
            Me.xrTableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.OrderDetailsProducts.ProductName")})
            Me.xrTableCell24.Name = "xrTableCell24"
            Me.xrTableCell24.StyleName = "DetailData3"
            Me.xrTableCell24.Text = "xrTableCell24"
            Me.xrTableCell24.Weight = 0R
            ' 
            ' xrTableCell25
            ' 
            Me.xrTableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.OrderDetailsProducts.UnitPrice", "{0:C2}")})
            Me.xrTableCell25.Name = "xrTableCell25"
            Me.xrTableCell25.StyleName = "DetailData3"
            Me.xrTableCell25.StylePriority.UseTextAlignment = False
            Me.xrTableCell25.Text = "xrTableCell25"
            Me.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell25.Weight = 0R
            ' 
            ' xrTableCell26
            ' 
            Me.xrTableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.OrderDetailsProducts.UnitsInStock")})
            Me.xrTableCell26.Name = "xrTableCell26"
            Me.xrTableCell26.StyleName = "DetailData3"
            Me.xrTableCell26.StylePriority.UseTextAlignment = False
            Me.xrTableCell26.Text = "xrTableCell26"
            Me.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell26.Weight = 0R
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Tahoma", 14F)
            Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
            Me.Title.Name = "Title"
            ' 
            ' GroupCaption1
            ' 
            Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(162)))), (CInt((CByte(162)))), (CInt((CByte(162)))))
            Me.GroupCaption1.BorderColor = System.Drawing.Color.White
            Me.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupCaption1.BorderWidth = 2F
            Me.GroupCaption1.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(228)))), (CInt((CByte(228)))), (CInt((CByte(228)))))
            Me.GroupCaption1.Name = "GroupCaption1"
            Me.GroupCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' GroupData1
            ' 
            Me.GroupData1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(162)))), (CInt((CByte(162)))), (CInt((CByte(162)))))
            Me.GroupData1.BorderColor = System.Drawing.Color.White
            Me.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupData1.BorderWidth = 2F
            Me.GroupData1.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.GroupData1.ForeColor = System.Drawing.Color.White
            Me.GroupData1.Name = "GroupData1"
            Me.GroupData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailCaption1
            ' 
            Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
            Me.DetailCaption1.BorderColor = System.Drawing.Color.White
            Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailCaption1.BorderWidth = 2F
            Me.DetailCaption1.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.DetailCaption1.ForeColor = System.Drawing.Color.White
            Me.DetailCaption1.Name = "DetailCaption1"
            Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData1
            ' 
            Me.DetailData1.BackColor = System.Drawing.Color.Transparent
            Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailData1.BorderWidth = 2F
            Me.DetailData1.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.DetailData1.ForeColor = System.Drawing.Color.Black
            Me.DetailData1.Name = "DetailData1"
            Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailCaption3
            ' 
            Me.DetailCaption3.BackColor = System.Drawing.Color.Transparent
            Me.DetailCaption3.BorderColor = System.Drawing.Color.Transparent
            Me.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailCaption3.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
            Me.DetailCaption3.Name = "DetailCaption3"
            Me.DetailCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3
            ' 
            Me.DetailData3.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.DetailData3.ForeColor = System.Drawing.Color.Black
            Me.DetailData3.Name = "DetailData3"
            Me.DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3_Odd
            ' 
            Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
            Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailData3_Odd.BorderWidth = 1F
            Me.DetailData3_Odd.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
            Me.DetailData3_Odd.Name = "DetailData3_Odd"
            Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailCaptionBackground3
            ' 
            Me.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent
            Me.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(206)))), (CInt((CByte(206)))), (CInt((CByte(206)))))
            Me.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.DetailCaptionBackground3.BorderWidth = 2F
            Me.DetailCaptionBackground3.Name = "DetailCaptionBackground3"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
            Me.PageInfo.Name = "PageInfo"
            Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' OrdersReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.reportHeaderBand1, Me.groupHeaderBand1, Me.detailReportBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "OrderDetails"
            Me.DataSource = Me.sqlDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.GroupCaption1, Me.GroupData1, Me.DetailCaption1, Me.DetailData1, Me.DetailCaption3, Me.DetailData3, Me.DetailData3_Odd, Me.DetailCaptionBackground3, Me.PageInfo})
            Me.Version = "17.1"
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    #End Region
End Class
