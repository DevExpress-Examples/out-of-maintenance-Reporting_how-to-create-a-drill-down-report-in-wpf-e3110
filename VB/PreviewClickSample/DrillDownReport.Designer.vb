Imports Microsoft.VisualBasic
Imports System
Namespace PreviewClickSample
	Partial Public Class DrillDownReport
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
            Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim SecondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.lbShowHide = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.nwindDataSet1 = New PreviewClickSample.nwindDataSet()
            Me.categoriesTableAdapter = New PreviewClickSample.nwindDataSetTableAdapters.CategoriesTableAdapter()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
            Me.productsTableAdapter = New PreviewClickSample.nwindDataSetTableAdapters.ProductsTableAdapter()
            Me.expandedValuesParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.xrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.calculatedField2 = New DevExpress.XtraReports.UI.CalculatedField()
            CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SecondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1, Me.lbShowHide, Me.xrLabel2, Me.xrLabel1})
            Me.Detail.HeightF = 97.37502!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrPictureBox1
            '
            Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(561.8749!, 10.00004!)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(165.625!, 79.99998!)
            '
            'lbShowHide
            '
            Me.lbShowHide.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "Categories.CategoryID")})
            Me.lbShowHide.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.lbShowHide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lbShowHide.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 67.00001!)
            Me.lbShowHide.Name = "lbShowHide"
            Me.lbShowHide.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.lbShowHide.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
            Me.lbShowHide.StylePriority.UseFont = False
            Me.lbShowHide.StylePriority.UseForeColor = False
            Me.lbShowHide.StylePriority.UseTextAlignment = False
            Me.lbShowHide.Text = "Show Detail"
            Me.lbShowHide.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'xrLabel2
            '
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
            Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel2.ForeColor = System.Drawing.Color.DimGray
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 39.24999!)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(420.0!, 23.0!)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "xrLabel2"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'xrLabel1
            '
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(420.0!, 29.25!)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'TopMargin
            '
            Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1})
            Me.TopMargin.HeightF = 49.0!
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrPageInfo1
            '
            Me.xrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrPageInfo1.ForeColor = System.Drawing.Color.DimGray
            Me.xrPageInfo1.Format = "Page #{0} of {1}"
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
            Me.xrPageInfo1.StylePriority.UseFont = False
            Me.xrPageInfo1.StylePriority.UseForeColor = False
            '
            'BottomMargin
            '
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo2})
            Me.BottomMargin.HeightF = 49.0!
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrPageInfo2
            '
            Me.xrPageInfo2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrPageInfo2.ForeColor = System.Drawing.Color.DimGray
            Me.xrPageInfo2.Format = "Page #{0} of {1}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
            Me.xrPageInfo2.StylePriority.UseFont = False
            Me.xrPageInfo2.StylePriority.UseForeColor = False
            '
            'nwindDataSet1
            '
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'categoriesTableAdapter
            '
            Me.categoriesTableAdapter.ClearBeforeFill = True
            '
            'DetailReport
            '
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1, Me.ReportFooter, Me.GroupFooter1})
            Me.DetailReport.DataAdapter = Me.productsTableAdapter
            Me.DetailReport.DataMember = "Categories.CategoriesProducts"
            Me.DetailReport.DataSource = Me.nwindDataSet1
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            '
            'Detail1
            '
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.Detail1.HeightF = 25.0!
            Me.Detail1.Name = "Detail1"
            '
            'xrTable2
            '
            Me.xrTable2.BorderColor = System.Drawing.Color.LightGray
            Me.xrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.OddStyleName = "xrControlStyle1"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100.0!)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(717.4999!, 25.0!)
            Me.xrTable2.StylePriority.UseBorderColor = False
            Me.xrTable2.StylePriority.UseBorders = False
            Me.xrTable2.StylePriority.UseFont = False
            Me.xrTable2.StylePriority.UsePadding = False
            Me.xrTable2.StylePriority.UseTextAlignment = False
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'xrTableRow2
            '
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6, Me.xrTableCell8})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1.0R
            '
            'xrTableCell4
            '
            Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell4.Weight = 1.3238065866568374R
            '
            'xrTableCell5
            '
            Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.QuantityPerUnit")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell5.Weight = 0.63058689324340533R
            '
            'xrTableCell6
            '
            Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice", "{0:$0.00}")})
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.StylePriority.UseTextAlignment = False
            Me.xrTableCell6.Text = "xrTableCell6"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell6.Weight = 0.47719687356310375R
            '
            'xrTableCell8
            '
            Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsInStock")})
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.Weight = 0.70978955153604151R
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.GroupHeader1.HeightF = 25.0!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'xrTable1
            '
            Me.xrTable1.BackColor = System.Drawing.Color.Gainsboro
            Me.xrTable1.BorderColor = System.Drawing.Color.LightGray
            Me.xrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                Or DevExpress.XtraPrinting.BorderSide.Right) _
                Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(717.4999!, 25.0!)
            Me.xrTable1.StylePriority.UseBackColor = False
            Me.xrTable1.StylePriority.UseBorderColor = False
            Me.xrTable1.StylePriority.UseBorders = False
            Me.xrTable1.StylePriority.UseFont = False
            '
            'xrTableRow1
            '
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell7})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1.0R
            '
            'xrTableCell1
            '
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "Product Name"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 1.3238065866568374R
            '
            'xrTableCell2
            '
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.Text = "Quantity Per Unit"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.63058689324340533R
            '
            'xrTableCell3
            '
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "Unit Price"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell3.Weight = 0.47719687356310375R
            '
            'xrTableCell7
            '
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.StylePriority.UseTextAlignment = False
            Me.xrTableCell7.Text = "Units In Stock"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell7.Weight = 0.70978955153604151R
            '
            'ReportFooter
            '
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel1})
            Me.ReportFooter.HeightF = 75.0!
            Me.ReportFooter.Name = "ReportFooter"
            '
            'xrPanel1
            '
            Me.xrPanel1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.xrPanel1.BorderColor = System.Drawing.Color.Silver
            Me.xrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                Or DevExpress.XtraPrinting.BorderSide.Right) _
                Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel4, Me.xrLabel3})
            Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(12.36107!, 0.0!)
            Me.xrPanel1.Name = "xrPanel1"
            Me.xrPanel1.SizeF = New System.Drawing.SizeF(715.1389!, 75.0!)
            Me.xrPanel1.StylePriority.UseBackColor = False
            Me.xrPanel1.StylePriority.UseBorderColor = False
            Me.xrPanel1.StylePriority.UseBorders = False
            '
            'xrLabel4
            '
            Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.calculatedField2")})
            Me.xrLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel4.ForeColor = System.Drawing.Color.Maroon
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(290.0!, 42.00001!)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(415.1389!, 23.0!)
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UseForeColor = False
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            XrSummary1.FormatString = "Total inventory balance: {0:$0.00}"
            XrSummary1.IgnoreNullValues = True
            XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrLabel4.Summary = XrSummary1
            Me.xrLabel4.Text = "xrLabel4"
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'xrLabel3
            '
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsInStock")})
            Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel3.ForeColor = System.Drawing.Color.Maroon
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(290.0!, 10.00001!)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(415.1389!, 23.0!)
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UseForeColor = False
            Me.xrLabel3.StylePriority.UseTextAlignment = False
            XrSummary2.FormatString = "Total units in stock: {0}"
            XrSummary2.IgnoreNullValues = True
            XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrLabel3.Summary = XrSummary2
            Me.xrLabel3.Text = "xrLabel3"
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'GroupFooter1
            '
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrChart1})
            Me.GroupFooter1.HeightF = 392.7084!
            Me.GroupFooter1.Name = "GroupFooter1"
            '
            'xrChart1
            '
            Me.xrChart1.BorderColor = System.Drawing.Color.Black
            Me.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrChart1.DataSource = Me.nwindDataSet1
            XyDiagram1.AxisX.Label.Angle = -35
            XyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            XyDiagram1.AxisX.Title.Text = "Product Name"
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.Title.Text = "Units in Stock"
            XyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            SecondaryAxisY1.AxisID = 0
            SecondaryAxisY1.Label.TextPattern = "{}{A}: {V:F1}"
            SecondaryAxisY1.Name = "Secondary AxisY 1"
            SecondaryAxisY1.Title.Text = "Inventory Balance"
            SecondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            SecondaryAxisY1.VisibleInPanesSerializable = "-1"
            XyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY1})
            Me.xrChart1.Diagram = XyDiagram1
            Me.xrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.xrChart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.xrChart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.xrChart1.Legend.HorizontalIndent = 22
            Me.xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(10.00002!, 0.0!)
            Me.xrChart1.Name = "xrChart1"
            Me.xrChart1.PaletteName = "In A Fog"
            SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Series1.Label = SideBySideBarSeriesLabel1
            Series1.LegendText = "Units in Stock"
            Series1.Name = "Series 1"
            SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            SideBySideBarSeriesLabel2.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Center
            SideBySideBarSeriesLabel2.ShowForZeroValues = True
            SideBySideBarSeriesLabel2.TextPattern = "{V}"
            Series2.Label = SideBySideBarSeriesLabel2
            Series2.LegendText = "Inventory Balance"
            Series2.Name = "Series 2"
            SideBySideBarSeriesView1.AxisYName = "Secondary AxisY 1"
            Series2.View = SideBySideBarSeriesView1
            Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
            SideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.xrChart1.SeriesTemplate.Label = SideBySideBarSeriesLabel3
            Me.xrChart1.SizeF = New System.Drawing.SizeF(717.5!, 392.7084!)
            ChartTitle1.Text = "Products Inventory"
            Me.xrChart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
            '
            'productsTableAdapter
            '
            Me.productsTableAdapter.ClearBeforeFill = True
            '
            'expandedValuesParameter
            '
            Me.expandedValuesParameter.Name = "expandedValuesParameter"
            Me.expandedValuesParameter.Visible = False
            '
            'xrControlStyle1
            '
            Me.xrControlStyle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.xrControlStyle1.Name = "xrControlStyle1"
            Me.xrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            '
            'calculatedField2
            '
            Me.calculatedField2.DataMember = "Categories.CategoriesProducts"
            Me.calculatedField2.Expression = "[UnitPrice] *  [UnitsInStock]"
            Me.calculatedField2.Name = "calculatedField2"
            '
            'DrillDownReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calculatedField2})
            Me.DataAdapter = Me.categoriesTableAdapter
            Me.DataMember = "Categories"
            Me.DataSource = Me.nwindDataSet1
            Me.Margins = New System.Drawing.Printing.Margins(51, 50, 49, 49)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.expandedValuesParameter})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.xrControlStyle1})
            Me.Version = "14.2"
            CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SecondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private lbShowHide As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private expandedValuesParameter As DevExpress.XtraReports.Parameters.Parameter
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
		Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private WithEvents xrChart1 As DevExpress.XtraReports.UI.XRChart
		Private xrPanel1 As DevExpress.XtraReports.UI.XRPanel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private calculatedField2 As DevExpress.XtraReports.UI.CalculatedField
        Friend WithEvents xrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace
