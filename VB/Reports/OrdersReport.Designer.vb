Namespace MVCViewerWidgetDemo.Reports
    Partial Public Class OrdersReport
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

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
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim relationInfo1 As New DevExpress.DataAccess.Sql.RelationInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OrdersReport))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrLabel2, Me.xrLabel3, Me.xrLabel4, Me.xrLabel5, Me.xrLabel6, Me.xrLabel7, Me.xrLabel8, Me.xrLabel9, Me.xrLabel10, Me.xrLine1})
            Me.Detail.HeightF = 128F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 9F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel1.StyleName = "FieldCaption"
            Me.xrLabel1.Text = "Order ID"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(6F, 33F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel2.StyleName = "FieldCaption"
            Me.xrLabel2.Text = "Product Name"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(6F, 57F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel3.StyleName = "FieldCaption"
            Me.xrLabel3.Text = "Quantity"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(6F, 81F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel4.StyleName = "FieldCaption"
            Me.xrLabel4.Text = "Unit Price"
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(6F, 105F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel5.StyleName = "FieldCaption"
            Me.xrLabel5.Text = "Discount"
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.OrderID")})
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(174F, 9F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel6.StyleName = "DataField"
            Me.xrLabel6.Text = "xrLabel6"
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.ProductName")})
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(174F, 33F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel7.StyleName = "DataField"
            Me.xrLabel7.Text = "xrLabel7"
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Quantity")})
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(174F, 57F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel8.StyleName = "DataField"
            Me.xrLabel8.Text = "xrLabel8"
            ' 
            ' xrLabel9
            ' 
            Me.xrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.UnitPrice", "{0:C2}")})
            Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(174F, 81F)
            Me.xrLabel9.Name = "xrLabel9"
            Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel9.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel9.StyleName = "DataField"
            Me.xrLabel9.Text = "xrLabel9"
            ' 
            ' xrLabel10
            ' 
            Me.xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Discount")})
            Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(174F, 105F)
            Me.xrLabel10.Name = "xrLabel10"
            Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel10.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel10.StyleName = "DataField"
            Me.xrLabel10.Text = "xrLabel10"
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 3F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(638F, 2F)
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
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "OrderDetails"
            relationColumnInfo1.NestedKeyColumn = "ProductID"
            relationColumnInfo1.ParentKeyColumn = "ProductID"
            relationInfo1.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() { relationColumnInfo1})
            relationInfo1.NestedTable = "Products"
            relationInfo1.ParentTable = "OrderDetails"
            tableQuery1.Relations.AddRange(New DevExpress.DataAccess.Sql.RelationInfo() { relationInfo1})
            tableInfo1.Name = "OrderDetails"
            columnInfo1.Name = "OrderID"
            columnInfo2.Name = "ProductID"
            columnInfo3.Name = "UnitPrice"
            columnInfo4.Name = "Quantity"
            columnInfo5.Name = "Discount"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5})
            tableInfo2.Name = "Products"
            columnInfo6.Name = "ProductName"
            tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo6})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1, tableInfo2})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' pageFooterBand1
            ' 
            Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPageInfo2})
            Me.pageFooterBand1.HeightF = 29F
            Me.pageFooterBand1.Name = "pageFooterBand1"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.xrPageInfo1.StyleName = "PageInfo"
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Format = "Page {0} of {1}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.xrPageInfo2.StyleName = "PageInfo"
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' reportHeaderBand1
            ' 
            Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel11})
            Me.reportHeaderBand1.HeightF = 51F
            Me.reportHeaderBand1.Name = "reportHeaderBand1"
            ' 
            ' xrLabel11
            ' 
            Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrLabel11.Name = "xrLabel11"
            Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel11.SizeF = New System.Drawing.SizeF(638F, 33F)
            Me.xrLabel11.StyleName = "Title"
            Me.xrLabel11.Text = "Top 100 orders"
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' OrdersReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.pageFooterBand1, Me.reportHeaderBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "OrderDetails"
            Me.DataSource = Me.sqlDataSource1
            Me.ReportPrintOptions.DetailCount = 100
            Me.ReportPrintOptions.DetailCountAtDesignTime = 100
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "15.2"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
        Private xrLine1 As DevExpress.XtraReports.UI.XRLine
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Private reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
        Private Title As DevExpress.XtraReports.UI.XRControlStyle
        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private DataField As DevExpress.XtraReports.UI.XRControlStyle
    End Class
End Namespace
