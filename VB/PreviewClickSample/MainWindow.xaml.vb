Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports.UI
' ...

Namespace PreviewClickSample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Private ReadOnly report_Renamed As New DrillDownReport()

		Private ReadOnly Property Report() As XtraReport
			Get
				Return report_Renamed
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			ThemeManager.ApplicationThemeName = "Azure"
			AddHandler Loaded, AddressOf MainWindow_Loaded
		End Sub

		Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim model As New XtraReportPreviewModel(report_Renamed)
			AddHandler model.PreviewMouseMove, AddressOf model_PreviewMouseMove
			AddHandler model.PreviewClick, AddressOf model_PreviewClick
			preview.Model = model
			report_Renamed.CreateDocument(False)
		End Sub

		Private Sub model_PreviewClick(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
			If e.ElementTag <> String.Empty Then
				Dim expandedValues As List(Of Integer) = CType(report_Renamed.Parameters("expandedValuesParameter").Value, List(Of Integer))
				Dim index As Integer
				If (Not Integer.TryParse(e.ElementTag, index)) Then
					Return
				End If

				If expandedValues.Contains(index) Then
					expandedValues.Remove(index)
				Else
					expandedValues.Add(index)
				End If
				Report.CreateDocument(False)
			End If
		End Sub

		Private Sub model_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
			If e.ElementTag IsNot Nothing AndAlso (Not e.ElementTag.Equals(String.Empty)) Then
				e.Control.Cursor = Cursors.Hand
			End If
		End Sub
	End Class
End Namespace
