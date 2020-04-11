Public Class FrmLogin
    Public User As ClsLogin
    Private Sub BtnCancell_Click(sender As Object, e As EventArgs) Handles BtnCancell.Click
        Application.Exit()
    End Sub
    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Dim dialog As New UserControls.ClsDialog
        Try
            User = New ClsLogin(Me.TxtUser.Text)
            If Not User.Exsists Then
                dialog.ShowErorr("نام کاربری اشتباه است")
                Exit Sub
            End If
            If User.Pass = Me.TxtPass.Text Then
                Me.Visible = False
                RegisterKey("User_Name", User.User_Name.ToString.Trim)
                Dim FrmMain As New Main.FrmMain(User.User_Name)
                If System.Diagnostics.Debugger.IsAttached Then
                    FrmMain.Show()
                Else
                    FrmMain.ShowDialog()
                End If

                Me.Close()
            Else
                dialog.ShowErorr("رمز عبور اشتباه است")
                Exit Sub
            End If
        Catch ex As Exception
            dialog.ShowErorr("مشکلی در اجرای برنامه پیش آمده", ex.Message)
            End
        End Try
    End Sub
    Private Sub TxtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUser.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.TxtPass.Focus()
            Me.TxtPass.Select(0, Me.TxtPass.Text.Length)
        ElseIf e.KeyData = Keys.Escape Then
            Me.BtnCancell_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPass.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.BtnEnter_Click(Nothing, Nothing)
        ElseIf e.KeyData = Keys.Escape Then
            Me.BtnCancell_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BtnEnter_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnEnter.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.BtnCancell_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BtnCancell_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnCancell.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.BtnCancell_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub FrmLogin_InputLanguageChanged(sender As Object, e As InputLanguageChangedEventArgs) Handles Me.InputLanguageChanged
        Me.LblLanguage.Text = (Mid(e.Culture.ThreeLetterWindowsLanguageName.Trim, 1, 2))
    End Sub
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.LblLanguage.Text = (Mid(InputLanguage.CurrentInputLanguage.Culture.ThreeLetterWindowsLanguageName.Trim, 1, 2))
    End Sub
    Private Sub FrmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If System.Diagnostics.Debugger.IsAttached And My.Computer.Keyboard.ShiftKeyDown = False Then
            Me.TxtUser.Text = "Admin"
            Me.TxtPass.Text = "2019"
            Application.DoEvents()
            BtnEnter_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub TxtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUser.KeyPress
        Dim ValidChar As String = "ABCDEFQWERTYUIOPLKJHGFDSAZXCVBNMqwertyuioplkjhgfdsazxcvbnm1234567890"
        If e.KeyChar = Chr(System.Windows.Forms.Keys.Back) Or e.KeyChar = Chr(System.Windows.Forms.Keys.Enter) Then
            e.Handled = False
        ElseIf ValidChar.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtUser_Enter(sender As Object, e As EventArgs) Handles TxtUser.Enter, TxtUser.Click, TxtUser.DoubleClick
        TxtUser.Select(0, TxtUser.Text.Length)
    End Sub

    Private Sub TxtPass_Enter(sender As Object, e As EventArgs) Handles TxtPass.Enter, TxtPass.Click, TxtPass.DoubleClick
        TxtPass.Select(0, TxtPass.Text.Length)
    End Sub

    Public Sub New()
        Main()
        InitializeComponent()
    End Sub
End Class