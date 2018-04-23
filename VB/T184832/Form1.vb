Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010

Namespace T184832
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
			AddHandler documentManager1.View.CustomDocumentsHostWindow, AddressOf View_CustomDocumentsHostWindow
			documentManager1.View.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost
		End Sub

		Private Sub tabbedView1_QueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs) Handles tabbedView1.QueryControl
			e.Control = New Control()
		End Sub

		Private Sub View_CustomDocumentsHostWindow(ByVal sender As Object, ByVal e As CustomDocumentsHostWindowEventArgs)
			e.Constructor = New DevExpress.XtraBars.Docking2010.DocumentsHostWindowConstructor(AddressOf CreateCustomHost)
		End Sub

		Private Function CreateCustomHost() As CustomDocHost
			Return New CustomDocHost()
		End Function
	End Class

	Public Class CustomDocHost
		Inherits Form
		Implements IDocumentsHostWindow
		Private floatDocHost As DocumentManager

		Public Sub New()
			floatDocHost = New DocumentManager()
			floatDocHost.ContainerControl = Me
			AddHandler floatDocHost.View.DocumentClosing, AddressOf View_DocumentClosing
			floatDocHost.View.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost
		End Sub

		Private Sub View_DocumentClosing(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.DocumentCancelEventArgs)
			'do something 
		End Sub

        Public ReadOnly Property DestroyOnRemovingChildren() As Boolean Implements IDocumentsHostWindow.DestroyOnRemovingChildren
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property DocumentManager() As DocumentManager Implements IDocumentsHostWindow.DocumentManager
            Get
                Return floatDocHost
            End Get
        End Property

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				floatDocHost.Dispose()
			End If
			MyBase.Dispose(disposing)
        End Sub

        Public Overloads Sub Close() Implements IDocumentsHostWindow.Close
            MyBase.Close()
        End Sub

        Public Overloads Sub Hide() Implements IDocumentsHostWindow.Hide
            MyBase.Hide()
        End Sub

        Public Overloads Sub Show() Implements IDocumentsHostWindow.Show
            MyBase.Show()
        End Sub

        Shadows Event Closing(ByVal sender As Object, ByVal e As CancelEventArgs) Implements IDocumentsHostWindow.Closing

        Shadows Event Closed(ByVal sender As Object, ByVal e As EventArgs) Implements IDocumentsHostWindow.Closed
    End Class
End Namespace
