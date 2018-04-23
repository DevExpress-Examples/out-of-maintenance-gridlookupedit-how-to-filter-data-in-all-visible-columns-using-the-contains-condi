Imports Microsoft.VisualBasic
Imports System
Namespace GridLookUpEdit_MultiAutoSearch
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
			Me.nwindDataSet = New GridLookUpEdit_MultiAutoSearch.nwindDataSet()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.customersTableAdapter = New GridLookUpEdit_MultiAutoSearch.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.customGridLookUpEdit1 = New GridLookUpEdit_MultiAutoSearch.CustomGridLookUpEdit()
			Me.customGridLookUpEdit1View = New GridLookUpEdit_MultiAutoSearch.CustomGridView()
			Me.gridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
			Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customGridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindDataSet
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' customGridLookUpEdit1
			' 
			Me.customGridLookUpEdit1.Location = New System.Drawing.Point(56, 43)
			Me.customGridLookUpEdit1.Name = "customGridLookUpEdit1"
			Me.customGridLookUpEdit1.Properties.AutoComplete = False
			Me.customGridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.customGridLookUpEdit1.Properties.DataSource = Me.customersBindingSource
			Me.customGridLookUpEdit1.Properties.DisplayMember = "ContactName"
			Me.customGridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.customGridLookUpEdit1.Properties.View = Me.customGridLookUpEdit1View
			Me.customGridLookUpEdit1.Size = New System.Drawing.Size(175, 20)
			Me.customGridLookUpEdit1.TabIndex = 0
			' 
			' customGridLookUpEdit1View
			' 
			Me.customGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
			Me.customGridLookUpEdit1View.Name = "customGridLookUpEdit1View"
			Me.customGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.customGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
			' 
			' gridLookUpEdit1
			' 
			Me.gridLookUpEdit1.Location = New System.Drawing.Point(56, 104)
			Me.gridLookUpEdit1.Name = "gridLookUpEdit1"
			Me.gridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.gridLookUpEdit1.Properties.DataSource = Me.customersBindingSource
			Me.gridLookUpEdit1.Properties.DisplayMember = "ContactName"
			Me.gridLookUpEdit1.Properties.View = Me.gridLookUpEdit1View
			Me.gridLookUpEdit1.Size = New System.Drawing.Size(175, 20)
			Me.gridLookUpEdit1.TabIndex = 1
			' 
			' gridLookUpEdit1View
			' 
			Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
			Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
			Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 262)
			Me.Controls.Add(Me.gridLookUpEdit1)
			Me.Controls.Add(Me.customGridLookUpEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customGridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private nwindDataSet As nwindDataSet
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private customersTableAdapter As GridLookUpEdit_MultiAutoSearch.nwindDataSetTableAdapters.CustomersTableAdapter
		Private customGridLookUpEdit1 As CustomGridLookUpEdit
		Private customGridLookUpEdit1View As CustomGridView
		Private gridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
		Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	End Class
End Namespace

