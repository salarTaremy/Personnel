Public Class FrmVahedKhedmat
    Dim VahedKhedmat As New ClsPersonBase.VahedKhedmat
    Private Sub FrmVahedKhedmat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrd()
    End Sub
    Private Sub FillGrd()
        Dim VahedKhedmat As New ClsPersonBase.VahedKhedmat
        Me.Grd.DataSource = VahedKhedmat.GetAll
        Grd.Columns("Name").HeaderText = "نام"
        Grd.Columns("Detail").HeaderText = "توضیحات"
        Grd.Columns("ID").ReadOnly = True
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        VahedKhedmat.AddNew(Me.TxtName.Text, Me.TxtDetail.Text)
        FillGrd()
        Me.TxtDetail.Text = Nothing
        Me.TxtName.Text = Nothing
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If VahedKhedmat.Delete(Me.Grd.CurrentRow.Cells("ID").Value) Then
            FillGrd()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        VahedKhedmat.Update(Me.Grd.DataSource)
    End Sub
End Class