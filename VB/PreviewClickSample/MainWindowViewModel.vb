Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows.Input
Imports DevExpress.Xpf.Printing
' ...

Namespace PreviewClickSample
	Public Class MainWindowViewModel
		Private ReadOnly report As New DrillDownReport()

		Private privatePreviewModel As XtraReportPreviewModel
		Public Property PreviewModel() As XtraReportPreviewModel
			Get
				Return privatePreviewModel
			End Get
			Private Set(ByVal value As XtraReportPreviewModel)
				privatePreviewModel = value
			End Set
		End Property

		Public Sub New()
			PreviewModel = New XtraReportPreviewModel(report)
			AddHandler PreviewModel.PreviewMouseMove, AddressOf model_PreviewMouseMove
			AddHandler PreviewModel.PreviewClick, AddressOf model_PreviewClick
			report.CreateDocument()
		End Sub

		Private Sub model_PreviewClick(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
			Dim index As Integer
			If String.IsNullOrEmpty(e.ElementTag) OrElse (Not Integer.TryParse(e.ElementTag, index)) Then
				Return
			End If
			Dim expandedValues = CType(report.Parameters("expandedValuesParameter").Value, List(Of Integer))
			If expandedValues.Contains(index) Then
				expandedValues.Remove(index)
			Else
				expandedValues.Add(index)
			End If
			report.CreateDocument(False)
		End Sub

		Private Sub model_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
			If (Not String.IsNullOrEmpty(e.ElementTag)) Then
				e.Element.Cursor = Cursors.Hand
			End If
		End Sub
	End Class
End Namespace
