Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace GridLookUpEdit_MultiAutoSearch
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            ' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)

        End Sub

        Private Sub gridLookUpEdit1_AutoSearch(sender As Object, e As DevExpress.XtraEditors.Controls.LookUpEditAutoSearchEventArgs) Handles gridLookUpEdit1.AutoSearch
            e.SetParameters(DevExpress.Data.Filtering.FindPanelParserKind.Exact, DevExpress.Data.Filtering.FilterCondition.Contains)
        End Sub
    End Class
End Namespace