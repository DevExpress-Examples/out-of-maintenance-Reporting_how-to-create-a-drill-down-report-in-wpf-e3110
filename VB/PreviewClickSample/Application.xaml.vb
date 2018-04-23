Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace PreviewClickSample
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application
		Protected Overrides Sub OnActivated(ByVal e As EventArgs)
			ThemeManager.ApplicationThemeName = "Azure"
		End Sub
	End Class
End Namespace
