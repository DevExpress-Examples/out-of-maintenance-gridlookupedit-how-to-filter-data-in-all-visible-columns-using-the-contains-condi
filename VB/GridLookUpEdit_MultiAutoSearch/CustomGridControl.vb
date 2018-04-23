Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator

Namespace GridLookUpEdit_MultiAutoSearch
	Public Class CustomGridView
		Inherits GridView
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Friend Overridable Sub SetGridControlAccessMetod(ByVal newControl As GridControl)
			SetGridControl(newControl)
		End Sub

		Protected Overrides Function OnCreateLookupDisplayFilter(ByVal text As String, ByVal displayMember As String) As String
			Dim subStringOperators As New List(Of CriteriaOperator)()
			For Each sString As String In text.Split(" "c)
				Dim exp As String = LikeData.CreateContainsPattern(sString)
				Dim columnsOperators As New List(Of CriteriaOperator)()
				For Each col As GridColumn In Columns
					If col.Visible AndAlso col.ColumnType Is GetType(String) Then
						columnsOperators.Add(New BinaryOperator(col.FieldName, exp, BinaryOperatorType.Like))
					End If
				Next col
				subStringOperators.Add(New GroupOperator(GroupOperatorType.Or, columnsOperators))
			Next sString
			Return New GroupOperator(GroupOperatorType.And, subStringOperators).ToString()
		End Function

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "CustomGridView"
			End Get
		End Property
		Protected Friend Overridable ReadOnly Property GetExtraFilterText() As String
			Get
				Return ExtraFilterText
			End Get
		End Property
	End Class

	Public Class CustomGridControl
		Inherits GridControl
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New CustomGridInfoRegistrator())
		End Sub

		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("CustomGridView")
		End Function

	End Class

	Public Class CustomGridPainter
		Inherits GridPainter
		Public Sub New(ByVal view As GridView)
			MyBase.New(view)
		End Sub

		Public Overridable Shadows ReadOnly Property View() As CustomGridView
			Get
				Return CType(MyBase.View, CustomGridView)
			End Get
		End Property

		Protected Overrides Sub DrawRowCell(ByVal e As GridViewDrawArgs, ByVal cell As GridCellInfo)
			cell.ViewInfo.MatchedStringUseContains = True
			cell.ViewInfo.MatchedString = View.GetExtraFilterText
			cell.State = GridRowCellState.Dirty
			e.ViewInfo.UpdateCellAppearance(cell)
			MyBase.DrawRowCell(e, cell)
		End Sub
	End Class

	Public Class CustomGridInfoRegistrator
		Inherits GridInfoRegistrator
		Public Sub New()
			MyBase.New()
		End Sub
		Public Overrides Function CreatePainter(ByVal view As BaseView) As BaseViewPainter
			Return New CustomGridPainter(TryCast(view, DevExpress.XtraGrid.Views.Grid.GridView))
		End Function
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "CustomGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Dim view As New CustomGridView()
			view.SetGridControlAccessMetod(grid)
			Return view
		End Function

	End Class

End Namespace
