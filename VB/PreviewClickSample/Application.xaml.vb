Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Windows

Namespace PreviewClickSample
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
        Inherits Application
        Protected Overrides Sub OnActivated(e As System.EventArgs)
            DevExpress.Xpf.Core.ThemeManager.ApplicationThemeName = "Azure"
        End Sub
	End Class
End Namespace
