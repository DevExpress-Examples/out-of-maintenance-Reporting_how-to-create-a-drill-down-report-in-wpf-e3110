Imports PreviewClickSample
Imports DevExpress.Xpf.Printing
Imports System.Collections.Generic
Imports System.Windows.Input

Namespace PreviewClickSample
    Public Class MainWindowViewModel
        ReadOnly report As DrillDownReport = New DrillDownReport
        Public Property PreviewModel As XtraReportPreviewModel

        Public Sub New()
            PreviewModel = New XtraReportPreviewModel(report)
            AddHandler PreviewModel.PreviewMouseMove, AddressOf model_PreviewMouseMove
            AddHandler PreviewModel.PreviewClick, AddressOf model_PreviewClick
            report.CreateDocument()
        End Sub

        Private Sub model_PreviewClick(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
            If String.IsNullOrEmpty(e.ElementTag) Then
                Return
            End If
            Dim expandedValues As List(Of Integer) = CType(report.Parameters("expandedValuesParameter").Value, List(Of Integer))
            Dim index As Integer
            If (Not Integer.TryParse(e.ElementTag, index)) Then
                Return
            End If

            If expandedValues.Contains(index) Then
                expandedValues.Remove(index)
            Else
                expandedValues.Add(index)
            End If
            report.CreateDocument(False)
        End Sub

        Private Sub model_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
            If Not String.IsNullOrEmpty(e.ElementTag) Then
                e.Element.Cursor = Cursors.Hand
            End If
        End Sub
    End Class
End Namespace