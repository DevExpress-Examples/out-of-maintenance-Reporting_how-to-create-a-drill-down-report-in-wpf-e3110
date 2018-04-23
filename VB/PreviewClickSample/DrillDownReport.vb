Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing.Printing
Imports System.Linq
Imports DevExpress.XtraReports.UI
' ...

Namespace PreviewClickSample
	Partial Public Class DrillDownReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Private Const sShowDetail As String = "Show Detail"
		Private Const sHideDetail As String = "Hide Detail"

		Public Sub New()
			InitializeComponent()
			expandedValuesParameter.Type = GetType(List(Of Integer))
			expandedValuesParameter.Value = New List(Of Integer)()
			AddHandler lbShowHide.BeforePrint, AddressOf lbShowHide_BeforePrint
			AddHandler DetailReport.BeforePrint, AddressOf DetailReport_BeforePrint
		End Sub

		Private ReadOnly Property ExpandedValues() As List(Of Integer)
			Get
				Return CType(expandedValuesParameter.Value, List(Of Integer))
			End Get
		End Property

		Private Function ShouldShowDetail(ByVal catID As Integer) As Boolean
			Return ExpandedValues.Contains(catID)
		End Function

		Private Sub lbShowHide_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs)
			Dim label As XRLabel = CType(sender, XRLabel)
			If ShouldShowDetail(CInt(Fix(label.Tag))) Then
				label.Text = sHideDetail
			Else
				label.Text = sShowDetail
			End If
		End Sub

		Private Sub DetailReport_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs)
			e.Cancel = Not ShouldShowDetail(CInt(Fix(GetCurrentColumnValue("CategoryID"))))
		End Sub

		' The following code populates the XRChart with data.
		Private Sub xrChart1_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles xrChart1.BeforePrint
			Dim chart = CType(sender, XRChart)
			Dim categoryId = CInt(Fix(GetCurrentColumnValue("CategoryID")))
            chart.DataSource = ( _
              From p In nwindDataSet1.Products _
              Where p.CategoryID = categoryId Select New With {Key .CategoryID = p.CategoryID, Key .ProductName = p.ProductName, _
                                                               Key .UnitsInStock = p.UnitsInStock, Key .myRow = p.UnitPrice * p.UnitsInStock}).ToArray()

			chart.Series(1).ArgumentDataMember = "ProductName"
			chart.Series(1).ValueDataMembers.AddRange(New String() { "myRow" })

			chart.Series(0).ArgumentDataMember = "ProductName"
			chart.Series(0).ValueDataMembers.AddRange(New String() { "UnitsInStock" })
		End Sub
	End Class
End Namespace
