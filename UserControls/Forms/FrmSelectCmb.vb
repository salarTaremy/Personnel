Imports System.Windows.Forms
Public Class FrmSelectCmb
    Dim CmbBox As Telerik.WinControls.UI.RadDropDownList
    Dim Dialog As UserControls.ClsDialog
    Public Sub New(Cmb As Telerik.WinControls.UI.RadDropDownList)
        Me.CmbBox = Cmb
        InitializeComponent()
        Me.Grd.DataSource = CmbBox.DataSource
        For i As Integer = 0 To Me.Grd.Columns.Count - 1
            Me.Grd.Columns(i).IsVisible = False
        Next
        'Me.Grd.Columns(CmbBox.ValueMember).IsVisible = True
        Me.Grd.Columns(CmbBox.DisplayMember).IsVisible = True
        Me.Grd.Columns(CmbBox.DisplayMember).HeaderText = "جستجو:"
        Me.Grd.Columns(CmbBox.DisplayMember).Width = Grd.Width - 1
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Me.Grd.ChildRows.Count = 0 Then
            Dialog.ShowInfo("ایتمی برای انتخاب وجود ندارد")
            Exit Sub
        End If
        If Me.Grd.CurrentRow Is Nothing Then
            Dialog.ShowInfo("شما ایتمی انتخاب نکرده اید")
            Exit Sub
        End If
        If Me.Grd.CurrentRow.Cells(CmbBox.ValueMember).Value Is Nothing Then
            Dialog.ShowInfo("شما ایتمی انتخاب نکرده اید")
            Exit Sub
        End If
        CmbBox.SelectedValue = Me.Grd.CurrentRow.Cells(CmbBox.ValueMember).Value
        Me.Close()
    End Sub

    Private Sub Grd_KeyDown(sender As Object, e As KeyEventArgs) Handles Grd.KeyDown
        If e.KeyData = Keys.Enter Then
            BtnSelect_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Grd_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles Grd.CellDoubleClick
        BtnSelect_Click(Nothing, Nothing)
    End Sub
End Class