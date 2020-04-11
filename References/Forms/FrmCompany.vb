Public Class FrmCompany
    Dim Company As New ClsGeneral.Company
    Private Sub FrmKargah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrd()
    End Sub
    Private Sub FillGrd()
        Company = New ClsGeneral.Company
        Me.Grd.DataSource = Company.GetAll
        Grd.Columns("CodeEghtesadi").HeaderText = "کد اقتصادی"
        Grd.Columns("Name").HeaderText = "نام"
        Grd.Columns("Detail").HeaderText = "توضیحات"
        Grd.Columns("ID").ReadOnly = True
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtCode.Text = Nothing Or TxtCode.Text = "" Then
            Dialog.ShowInfo("کد اقتصادی نمیتواند خالی باشد")
            Exit Sub
        End If
        If TxtName.Text = Nothing Or TxtCode.Text = "" Then
            Dialog.ShowInfo("وارد کردن نام شرکت الزامی است")
            Exit Sub
        End If
        Company.AddNew(Me.TxtCode.Text.Trim, TxtName.Text.Trim, TxtDetail.Text.Trim)
        FillGrd()
        Me.TxtDetail.Text = Nothing
        Me.TxtCode.Text = Nothing
        Me.TxtName.Text = Nothing
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.Grd.CurrentRow Is Nothing Then
            Exit Sub
        End If
        If Company.Delete(Me.Grd.CurrentRow.Cells("ID").Value) Then
            FillGrd()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Company.Update(Me.Grd.DataSource)
        FillGrd()
    End Sub
End Class