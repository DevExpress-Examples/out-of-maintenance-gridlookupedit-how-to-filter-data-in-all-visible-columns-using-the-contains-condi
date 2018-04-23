Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base

Namespace GridLookUpEdit_MultiAutoSearch
    <UserRepositoryItem("RegisterCustomGridLookUpEdit")> _
    Public Class RepositoryItemCustomGridLookUpEdit
        Inherits RepositoryItemGridLookUpEdit

        Shared Sub New()
            RegisterCustomGridLookUpEdit()
        End Sub

        Public Sub New()
            TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            AutoComplete = False
        End Sub
        <Browsable(False)> _
        Public Overrides Property TextEditStyle() As DevExpress.XtraEditors.Controls.TextEditStyles
            Get
                Return MyBase.TextEditStyle
            End Get
            Set(ByVal value As DevExpress.XtraEditors.Controls.TextEditStyles)
                MyBase.TextEditStyle = value
            End Set
        End Property
        Public Const CustomGridLookUpEditName As String = "CustomGridLookUpEdit"

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return CustomGridLookUpEditName
            End Get
        End Property

        Public Shared Sub RegisterCustomGridLookUpEdit()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomGridLookUpEditName, GetType(CustomGridLookUpEdit), GetType(RepositoryItemCustomGridLookUpEdit), GetType(GridLookUpEditBaseViewInfo), New ButtonEditPainter(), True))
        End Sub

        Protected Overrides Function CreateViewInstance() As ColumnView
            Return New CustomGridView()
        End Function
        Protected Overrides Function CreateGrid() As GridControl
            Return New CustomGridControl()
        End Function
    End Class


    Public Class CustomGridLookUpEdit
        Inherits GridLookUpEdit

        Shared Sub New()
            RepositoryItemCustomGridLookUpEdit.RegisterCustomGridLookUpEdit()
        End Sub

        Public Sub New()
            MyBase.New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemCustomGridLookUpEdit.CustomGridLookUpEditName
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemCustomGridLookUpEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomGridLookUpEdit)
            End Get
        End Property
    End Class
End Namespace
