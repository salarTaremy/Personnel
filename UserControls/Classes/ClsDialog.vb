Public Class ClsDialog
    Public Sub ShowInfo(Message As String)
        Dim Frm As New FrmInfo
        Frm.TxtMessage.Text = Message
        Frm.ShowDialog()
    End Sub
    Public Sub ShowOK(Message As String)
        Dim frm As New FrmOk
        frm.TxtMessage.Text = Message
        frm.ShowDialog()
    End Sub
    Public Sub ShowErorr(Message As String, Optional MoreInfo As String = Nothing)
        Dim frm As New FrmError
        frm.TxtMessage.Text = Message
        If MoreInfo Is Nothing Then
            frm.PageView.Pages.RemoveAt(1)
        Else
            frm.TxtMore.Text = MoreInfo
        End If
        frm.ShowDialog()
    End Sub
    Public Function ShowQuestion(Message As String) As Boolean
        Dim frm As New FrmQuestion
        frm.TxtMessage.Text = Message
        frm.ShowDialog()
        Return frm.Result
    End Function
    Public Sub ShowHelp(message As String, Optional Caption As String = Nothing)
        Dim Frm As New FrmHelp(Caption, Detail:=message)
        Frm.ShowDialog()
    End Sub
End Class
