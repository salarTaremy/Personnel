Public Class FrmHelp
    Private Sub BtnSee_Click(sender As Object, e As EventArgs) Handles BtnSee.Click
        Me.Close()
    End Sub

    Public Sub New(Caption As String, Detail As String)
        InitializeComponent()
        Me.LblInfo.Text = Caption
        Me.TxtInfo.Text = Detail
    End Sub
End Class