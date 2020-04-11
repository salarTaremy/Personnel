Public Class FrmSaveFileToDb
    Dim Ver As New ClsVersionControl
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Ver.AddFile()
        FillListBox()
    End Sub

    Private Sub FrmSaveFileToDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillListBox()
    End Sub
    Private Sub FillListBox()
        ListBox1.ValueMember = "Counter"
        ListBox1.DisplayMember = "Name"
        ListBox1.DataSource = Ver.GetFiles()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Ver.DeleteFile(ListBox1.SelectedValue.ToString.Trim)
        FillListBox()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Ver.SaveFile(ListBox1.SelectedValue.ToString.Trim)
    End Sub
End Class