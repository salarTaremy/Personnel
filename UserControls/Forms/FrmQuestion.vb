Friend Class FrmQuestion
    Public Result As Boolean = False

    Private Sub FrmQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Me.Result = True
        Me.Close()
    End Sub

    Private Sub BtnCancell_Click(sender As Object, e As EventArgs) Handles BtnCancell.Click
        Me.Result = False
        Me.Close()
    End Sub
End Class