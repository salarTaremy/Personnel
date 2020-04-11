Public Class FrmModifyUser
    Public UserName As String = Nothing
    Dim user As ClsUser
    Private Sub FrmModifyUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserName = Nothing Then
            Me.UserName = ActiveUser.User_Name.Trim
        End If
        user = New ClsUser(UserName)
        If ActiveUser.ISAdmin Then
            Me.TxtOldPass.Enabled = False
        End If
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If Me.UserName = Nothing Then
            Me.UserName = ActiveUser.Name.Trim
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If (Me.TxtNewPass.Text <> String.Empty Or Me.TxtNewPass2.Text <> String.Empty) AndAlso TxtNewPass.Text.Trim <> TxtNewPass2.Text.Trim Then
            Dialog.ShowInfo("رمز عبور جدید مغایرت دارد")
            Exit Sub
        End If
        If Me.TxtNewPass.Text = String.Empty Then
            Dialog.ShowInfo("رمز عبور نمیتواند خالی باشد")
            Exit Sub
        End If

        If ActiveUser.ISAdmin Then
            user.Pass = TxtNewPass.Text.Trim
            user.Modify()
        Else
            If TxtOldPass.Text.Trim <> user.Pass.Trim Then
                Dialog.ShowOK("رمز قبلی نا معتبر است")
                Exit Sub
            End If
            user.Pass = TxtNewPass.Text.Trim
            user.Modify()
        End If
        Me.Close()
    End Sub
End Class