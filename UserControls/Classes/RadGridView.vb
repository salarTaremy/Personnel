Imports System.Windows.Forms
Public Class RadGridView
    Inherits Telerik.WinControls.UI.RadGridView
    Dim _ValidChar As String = Nothing
    Dim Dialog As New ClsDialog
    Private _ProgressBar As Telerik.WinControls.UI.RadProgressBar
    Public Sub New()
        MyBase.EnableAlternatingRowColor = True
        MyBase.EnableGrouping = False
        MyBase.AllowAddNewRow = False
    End Sub
    Public Property ProgressBar() As Telerik.WinControls.UI.RadProgressBar
        Get
            Return _ProgressBar
        End Get
        Set(ByVal value As Telerik.WinControls.UI.RadProgressBar)
            _ProgressBar = value
        End Set
    End Property
    Public Sub ShowProgressBar(Optional Maximum As Integer = 100, Optional Width As Integer = 150)
        Me._ProgressBar = New Telerik.WinControls.UI.RadProgressBar
        Me._ProgressBar.MinimumSize = New Drawing.Size(100, 10)
        Me._ProgressBar.Width = Width
        Me._ProgressBar.Value1 = 0
        Me._ProgressBar.Maximum = Maximum
        Dim x As Integer = Me.Width
        Dim y As Integer = Me.Height
        x = x - Me._ProgressBar.Width
        x = x / 2
        y = y - Me._ProgressBar.Height
        y = y / 2
        Me._ProgressBar.Anchor = AnchorStyles.None
        Me._ProgressBar.Location = New Drawing.Point(x, y)
        Me.Controls.Add(Me._ProgressBar)
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub RadGridView_DataBindingComplete(sender As Object, e As Telerik.WinControls.UI.GridViewBindingCompleteEventArgs) Handles Me.DataBindingComplete
        Try
            Dim WidthOfAllColumns As Integer = 0
            Dim WidthOfGrd As Integer = MyBase.Width - 40
            Dim tafazol As Integer = 0

            If MyBase.Columns.Count = 0 Then
                Exit Sub
            End If
            MyBase.BestFitColumns(Telerik.WinControls.UI.BestFitColumnMode.DisplayedCells)
            For i As Integer = 0 To MyBase.Columns.Count - 1
                WidthOfAllColumns += MyBase.Columns(i).Width
            Next
            If WidthOfGrd > WidthOfAllColumns Then
                tafazol = WidthOfGrd - WidthOfAllColumns
                tafazol = tafazol / MyBase.Columns.Count
                For i As Integer = 0 To MyBase.Columns.Count - 1
                    MyBase.Columns(i).Width = MyBase.Columns(i).Width + tafazol
                Next
            End If
        Catch ex As Exception
            Dialog.ShowErorr("خطا در دیتا گرید", ex.Message)
        End Try
    End Sub
    Public Property ValidChar As String
        Get
            Return _ValidChar
        End Get
        Set(value As String)
            _ValidChar = value
        End Set
    End Property
    Private Sub RadGridView_ValueChanging(sender As Object, e As Telerik.WinControls.UI.ValueChangingEventArgs) Handles Me.ValueChanging
        If ValidChar = Nothing Or e.NewValue Is Nothing Then
            Exit Sub
        End If
        Try
            For i As Integer = 0 To e.NewValue.ToString.Length - 1
                Dim Val As String = Mid(e.NewValue, i + 1, 1)
                Dim Index As Integer = Me.ValidChar.IndexOf(Val)
                If Index < 0 Then
                    e.Cancel = True
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            Dialog.ShowErorr("خطا در دیتا گرید", ex.Message)
        End Try
    End Sub
    Public Sub SetRowBackColor(RowIndex As Integer, Color As System.Drawing.Color)
        For i As Integer = 0 To MyBase.Columns.Count - 1
            MyBase.Rows(RowIndex).Cells(i).Style.CustomizeFill = True
            MyBase.Rows(RowIndex).Cells(i).Style.BackColor = Color
        Next
    End Sub
    Public Sub SetRowForeColor(RowIndex As Integer, Color As System.Drawing.Color)
        For i As Integer = 0 To MyBase.Columns.Count - 1
            MyBase.Rows(RowIndex).Cells(i).Style.ForeColor = Color
        Next
    End Sub
    Public Function GetSelectedItems(ColumnName As String) As DataTable
        Dim Dt As New DataTable
        Dim Dr As DataRow
        Dt.Columns.Add("Value", GetType(System.Int32))
        For i As Integer = 0 To MyBase.SelectedRows.Count - 1
            Dr = Dt.NewRow()
            Dr("Value") = MyBase.SelectedRows.Item(i).Cells(ColumnName).Value
            Dt.Rows.Add(Dr)
        Next
        Return Dt
    End Function
    Public Function ToDatatable(ParamArray ColumnName() As String) As DataTable
        Try
            Dim ReturnDt As New DataTable
            For i As Integer = 0 To ColumnName.Count - 1
                ReturnDt.Columns.Add(ColumnName(i), Type.GetType("System." & MyBase.DataSource.Columns(ColumnName(i)).DataType.Name))
            Next
            Dim Dr As DataRow
            For J As Integer = 0 To MyBase.Rows.Count - 1
                Dr = ReturnDt.NewRow()
                For i = 0 To ColumnName.Count - 1
                    Dr.Item(ColumnName(i)).GetType() ''= MyBase.Rows(J).Cells(ColumnName(i)).Value
                    Dr(ColumnName(i)) = MyBase.Rows(J).Cells(ColumnName(i)).Value
                Next
                ReturnDt.Rows.Add(Dr)
            Next
            Return ReturnDt
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
