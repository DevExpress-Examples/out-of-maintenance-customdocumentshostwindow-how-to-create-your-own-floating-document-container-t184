Imports Microsoft.VisualBasic
Imports System
Namespace T184832
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.documentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'documentManager1
            '
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.View = Me.tabbedView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView1})
            '
            'tabbedView1
            '
            Me.tabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.documentGroup1})
            Me.tabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.document1, Me.document2, Me.document3})
            '
            'documentGroup1
            '
            Me.documentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.document1, Me.document2, Me.document3})
            '
            'document1
            '
            Me.document1.Caption = "document1"
            Me.document1.ControlName = "document1"
            '
            'document2
            '
            Me.document2.Caption = "document2"
            Me.document2.ControlName = "document2"
            '
            'document3
            '
            Me.document3.Caption = "document3"
            Me.document3.ControlName = "document3"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(632, 278)
            Me.Name = "Form1"
            Me.Text = "CustomDocumentsHostWindow - How to create your own floating document container"
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
		Private WithEvents tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
		Private documentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
		Private document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document2 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document3 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

	End Class
End Namespace

