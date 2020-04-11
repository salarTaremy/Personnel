Public Class FrmEstekhdamType
    Dim EstekhdamType As ClsPersonBase.EstekhdamTypes
    Private Sub FrmEstekhdamType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrd()
    End Sub
    Private Sub FillGrd()
        EstekhdamType = New ClsPersonBase.EstekhdamTypes
        Me.Grd.DataSource = EstekhdamType.GetAll
        Grd.Columns("Name").HeaderText = "نام"
        Grd.Columns("Detail").HeaderText = "توضیحات"
        Grd.Columns("ID").ReadOnly = True
        
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        EstekhdamType.AddNew(Me.TxtName.Text, Me.TxtDetail.Text)
        FillGrd()
        Me.TxtDetail.Text = Nothing
        Me.TxtName.Text = Nothing
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If EstekhdamType.Delete(Me.Grd.CurrentRow.Cells("ID").Value) Then
            FillGrd()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        EstekhdamType.Update(Me.Grd.DataSource)
    End Sub
End Class