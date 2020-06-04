Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

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
            Me.nwindDataSet = New nwindDataSet()
            Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.customersTableAdapter = New nwindDataSetTableAdapters.CustomersTableAdapter()
            Me.gridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'nwindDataSet
            '
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'customersBindingSource
            '
            Me.customersBindingSource.DataMember = "Customers"
            Me.customersBindingSource.DataSource = Me.nwindDataSet
            '
            'customersTableAdapter
            '
            Me.customersTableAdapter.ClearBeforeFill = True
            '
            'gridLookUpEdit1
            '
            Me.gridLookUpEdit1.Location = New System.Drawing.Point(139, 132)
            Me.gridLookUpEdit1.Name = "gridLookUpEdit1"
            Me.gridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.gridLookUpEdit1.Properties.DataSource = Me.customersBindingSource
            Me.gridLookUpEdit1.Properties.DisplayMember = "ContactName"
            Me.gridLookUpEdit1.Properties.PopupView = Me.gridLookUpEdit1View
            Me.gridLookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch
            Me.gridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.gridLookUpEdit1.Size = New System.Drawing.Size(717, 20)
            Me.gridLookUpEdit1.TabIndex = 0
            '
            'gridLookUpEdit1View
            '
            Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
            Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1007, 321)
            Me.Controls.Add(Me.gridLookUpEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private nwindDataSet As nwindDataSet
        Private customersBindingSource As System.Windows.Forms.BindingSource
        Private customersTableAdapter As nwindDataSetTableAdapters.CustomersTableAdapter
        Private WithEvents gridLookUpEdit1 As GridLookUpEdit
        Private gridLookUpEdit1View As GridView
    End Class
End Namespace

