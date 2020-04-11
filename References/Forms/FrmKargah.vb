Public Class FrmKargah
    Dim kargah As New ClsPersonBase.Kargah
    Private Sub FrmKargah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrd()
    End Sub
    Private Sub FillGrd()
        kargah = New ClsPersonBase.Kargah
        Me.Grd.DataSource = kargah.GetAll
        Grd.Columns("CodeKargah").HeaderText = "کد کارگاه"
        Grd.Columns("Name").HeaderText = "نام"
        Grd.Columns("Detail").HeaderText = "توضیحات"
        Grd.Columns("ID").ReadOnly = True
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtCode.Text = Nothing Or TxtCode.Text = "" Then
            Dialog.ShowInfo("کد کارگاه نمیتواند خالی باشد")
            Exit Sub
        End If
        If TxtName.Text = Nothing Or TxtCode.Text = "" Then
            Dialog.ShowInfo("وارد کردن نام کارگاه الزامی است")
            Exit Sub
        End If
        kargah.AddNew(Me.TxtCode.Text.Trim, TxtName.Text.Trim, TxtDetail.Text.Trim)
        FillGrd()
        Me.TxtDetail.Text = Nothing
        Me.TxtCode.Text = Nothing
        Me.TxtName.Text = Nothing
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.Grd.CurrentRow Is Nothing Then
            Exit Sub
        End If
        If kargah.Delete(Me.Grd.CurrentRow.Cells("ID").Value) Then
            FillGrd()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Dim Dt_Kargah As New DataTable
        'Dt_Kargah = Me.Grd.DataSource
        kargah.Update(Me.Grd.DataSource)
    End Sub
End Class