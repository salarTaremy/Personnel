Imports System.Windows.Forms
Public Class UcTimePicker
    Public Property Txt As String
        Get
            Dim HH, MM As String
            HH = Me.HH.Text.ToString
            MM = Me.MM.Text.ToString
            If HH.Length = 1 Then
                HH = "0" & HH
            End If
            If MM.Length = 1 Then
                MM = "0" & MM
            End If
            Return HH & ":" & MM
        End Get
        Set(value As String)
            If value.ToString.Length = 8 Then
                value = Mid(value, 1, 5)
            End If
            If value.ToString.Length < 3 Then
                Me.Ap.Text = "AM"
                Me.HH.Text = "00"
                Me.MM.Text = "00"
            End If
            If value.ToString.Length = 3 Then
                Select Case value.ToString.IndexOf(":")
                    Case Is = 1
                        Me.HH.Text = Mid(value, 1, 1)
                        Me.MM.Text = Mid(value, 3, 1)
                    Case Is = 2
                        Me.HH.Text = Mid(value, 1, 2)
                        Me.MM.Text = "00"
                    Case Else
                        Me.HH.Text = "00"
                        Me.MM.Text = "00"
                End Select
            End If
            If value.ToString.Length = 5 Then
                If value.ToString.IndexOf(":") = 2 Then
                    Me.HH.Text = Mid(value, 1, 2)
                    Me.MM.Text = Mid(value, 4, 2)
                ElseIf value.ToString.IndexOf(":") = 3 Then
                    Me.HH.Text = Mid(value, 1, 3)
                    Me.MM.Text = Mid(value, 5, 1)
                Else
                    Me.HH.Text = "00"
                    Me.MM.Text = "00"
                End If
            End If
                If value.ToString.Length = 4 Then
                    Select Case value.ToString.IndexOf(":")
                        Case Is = 1
                            Me.HH.Text = Mid(value, 1, 1)
                            Me.MM.Text = Mid(value, 3, 2)
                        Case Is = 2
                            Me.HH.Text = Mid(value, 1, 2)
                            Me.MM.Text = Mid(value, 4, 1)
                        Case Else
                            Me.HH.Text = "00"
                            Me.MM.Text = "00"
                    End Select
            End If
            If Me.HH.Text.Length = 1 Then
                Me.HH.Text = "0" & Me.HH.Text
            End If
            If Me.MM.Text.Length = 1 Then
                Me.MM.Text = "0" & Me.MM.Text
            End If
        End Set
    End Property
    Private _ShowClockIcon As Boolean
    Public Property ShowClockIcon() As Boolean
        Get
            Return _ShowClockIcon
        End Get
        Set(ByVal value As Boolean)
            PictureBox1.Visible = value
            _ShowClockIcon = value
        End Set
    End Property
    Private _CheckDataEntry As Boolean = True
    Public Property CheckDataEntry() As Boolean
        Get
            Return _CheckDataEntry
        End Get
        Set(ByVal value As Boolean)
            If value = True Then
                HH.MaxLength = 2
            Else
                HH.MaxLength = 3
            End If
            _CheckDataEntry = value
        End Set
    End Property
    Public Function ToMinute() As Integer
        Dim ReturnValue As Integer
        ReturnValue = Val(HH.Text.Trim)
        ReturnValue *= 60
        Return ReturnValue + Val(MM.Text.Trim)
    End Function
    Private Sub TextBoxKeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles HH.KeyPress, MM.KeyPress
        Dim ValidCharacters As String = "0123456789"
        Dim ch As String = e.KeyChar.ToString
        If e.KeyChar = Chr(System.Windows.Forms.Keys.Back) Or e.KeyChar = Chr(System.Windows.Forms.Keys.Delete) Then
            e.Handled = False
        ElseIf ValidCharacters.IndexOf(ch) < 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub HH_LostFocus(sender As Object, e As EventArgs) Handles HH.LostFocus
        If HH.Text = "" Then
            HH.Text = "00"
            Exit Sub
        End If
        If CheckDataEntry AndAlso Val(HH.Text) > 23 Then
            MessageBox.Show("ساعت وارد شده نا معتبر است", "خطا در ورود اطلاعات ساعت", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            HH.Text = "00"
        End If
    End Sub

    Private Sub MM_LostFocus(sender As Object, e As EventArgs) Handles MM.LostFocus
        If MM.Text = "" Then
            MM.Text = "00"
            Exit Sub
        End If
        If Val(MM.Text) > 59 Then
            MessageBox.Show("دقیقه وارد شده نا معتبر است", "خطا در ورود اطلاعات ساعت", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            MM.Text = "00"
        End If
    End Sub

    Private Sub HH_KeyDown(sender As Object, e As KeyEventArgs) Handles HH.KeyDown
        If e.KeyCode = Keys.Enter Then
            MM.Focus()
            MM.Select(0, MM.Text.Length)
        End If
    End Sub

    Private Sub HH_TextChanged(sender As Object, e As EventArgs) Handles HH.TextChanged
        If Val(Me.HH.Text) >= 0 And Val(Me.HH.Text) < 12 Then
            Ap.Text = "AM"
            Ap.BackColor = System.Drawing.Color.FromArgb(192, 255, 192)
        ElseIf Val(Me.HH.Text) >= 12 And Val(Me.HH.Text) < 24 Then
            Ap.Text = "PM"
            Ap.BackColor = System.Drawing.Color.FromArgb(255, 192, 255)
        Else
            Ap.Text = "--"
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
