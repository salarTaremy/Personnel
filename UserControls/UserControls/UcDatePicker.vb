
Public Class UcDatePicker
    Public Property txt As String
        Get
            Dim tmp As String
            tmp = sal.Text.Trim & "/" & mah.Text.Trim & "/" & roz.Text.Trim
            If tmp.Length <> 10 Then
                'MsgBox("تاریخ ورودی  نامعتبر است")
                Return ""
            Else
                Return tmp
            End If
        End Get
        Set(value As String)
            If value = "" Or value = Nothing Then
                sal.Text = ""
                mah.Text = ""
                roz.Text = ""
                Exit Property
            End If
            If value.Length <> 10 Then
                MsgBox("طول تاریخ ورودی نا معتبر است")
                Exit Property
            ElseIf Mid(value, 5, 1) <> "/" Or Mid(value, 8, 1) <> "/" Then
                MsgBox("فرمت تاریخ ورودی نا معتبر است")
                Exit Property
            ElseIf Val(Mid(value, 1, 4)) < 1300 Or Val(Mid(value, 1, 4)) > 1500 Then
                MsgBox("سال وارد شده نا معتبر است")
                Exit Property
            ElseIf Val(Mid(value, 6, 2)) < 1 Or Val(Mid(value, 6, 2)) > 12 Then
                MsgBox("ماه وارد شده نا معتبر است")
                Exit Property
            ElseIf Val(Mid(value, 9, 2)) < 1 Or Val(Mid(value, 9, 2)) > 31 Then
                MsgBox("روز وارد شده نا معتبر است")
                Exit Property
            Else
                sal.Text = Mid(value, 1, 4)
                mah.Text = Mid(value, 6, 2)
                roz.Text = Mid(value, 9, 2)
            End If
        End Set
    End Property
    Public Property TxtInt As Integer
        Get
            Return CInt(Replace(Me.txt.Trim, "/", Nothing))
        End Get
        Set(value As Integer)
            If value.ToString.Length <> 8 Then
                Me.txt = Nothing
            Else
                Dim yy As String = Mid(value.ToString, 1, 4)
                Dim mm As String = Mid(value.ToString, 5, 2)
                Dim dd As String = Mid(value.ToString, 7, 2)
                Me.txt = yy & "/" & mm & "/" & dd
            End If
        End Set
    End Property
    Private Sub sal_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles sal.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            roz.Focus()
            roz.Select(0, sal.Text.Length)
        End If
    End Sub
    Private Sub TextBoxKeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles sal.KeyPress, mah.KeyPress, roz.KeyPress
        Dim ValidCharacters As String = "0123456789"
        Dim ch As String = e.KeyChar.ToString
        If e.KeyChar = Chr(System.Windows.Forms.Keys.Back) Or e.KeyChar = Chr(System.Windows.Forms.Keys.Delete) Then
            e.Handled = False
        ElseIf ValidCharacters.IndexOf(ch) < 0 Then
            e.Handled = True
        End If
    End Sub
    Public Function GetPersianDate() As String
        Dim NowDate As String = Format(Now, "yyyy/MM/dd")
        Dim Glob As New Globalization.PersianCalendar
        Dim y, m, d As String
        y = Glob.GetYear(NowDate)
        m = Glob.GetMonth(NowDate)
        d = Glob.GetDayOfMonth(NowDate)
        If m.Length = 1 Then
            m = "0" & m
        End If
        If d.Length = 1 Then
            d = "0" & d
        End If
        NowDate = y & "/" & m & "/" & d
        Return NowDate
    End Function
    Private Sub UcDatePicker_Load(sender As Object, e As EventArgs) Handles Me.Load
        'If sal.Text = "" Or mah.Text = "" Or roz.Text = "" Then
        '    Dim PersianDate = GetPersianDate()
        '    sal.Text = Mid(PersianDate, 1, 4)
        '    mah.Text = Mid(PersianDate, 6, 2)
        '    roz.Text = Mid(PersianDate, 9, 2)
        'End If
    End Sub

    Private Sub sal_LostFocus(sender As Object, e As EventArgs) Handles sal.LostFocus
        If sal.Text = "" Then
            Exit Sub
        End If
        If Val(sal.Text) > 1500 Or Val(sal.Text) < 1300 Then
            MsgBox("سال وارد شده  صحیح نیست ")
            sal.Focus()
            sal.Select(0, sal.Text.Length)
        End If
    End Sub

    Private Sub mah_KeyUp(sender As Object, e As Windows.Forms.KeyEventArgs) Handles mah.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            sal.Focus()
            sal.Select(0, sal.Text.Length)
        End If
    End Sub
    Private Sub mah_LostFocus(sender As Object, e As EventArgs) Handles mah.LostFocus
        If mah.Text = "" Then
            Exit Sub
        End If
        If Val(mah.Text) > 12 Or Val(mah.Text) < 1 Then
            MsgBox("ماه وارد شده  صحیح نیست ")
            mah.Focus()
            mah.Select(0, mah.Text.Length)
        End If
        If mah.Text.Length = 1 Then
            mah.Text = "0" & mah.Text
        End If
    End Sub

    Private Sub roz_KeyUp(sender As Object, e As Windows.Forms.KeyEventArgs) Handles roz.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            mah.Focus()
            mah.Select(0, mah.Text.Length)
        End If
    End Sub
    Private Sub roz_LostFocus(sender As Object, e As EventArgs) Handles roz.LostFocus
        If roz.Text = "" Then
            Exit Sub
        End If
        If Val(roz.Text) > 31 Or Val(roz.Text) < 1 Then
            MsgBox("روز وارد شده  صحیح نیست ")
            roz.Focus()
            roz.Select(0, roz.Text.Length)
        End If
        If roz.Text.Length = 1 Then
            roz.Text = "0" & roz.Text
        End If
    End Sub
    Public Sub SetDate(Value As FirstDay)
        If Value = FirstDay.FirstDayOfMonth Then
            Me.txt = Mid(GetPersianDate, 1, 8) & "01"
        ElseIf Value = FirstDay.FirstDayOfYear Then
            Me.txt = Mid(GetPersianDate, 1, 5) & "01/01"
        ElseIf Value = FirstDay.LastDayOfMonth Then
            Me.txt = Mid(GetPersianDate, 1, 8) & "31"
        ElseIf Value = FirstDay.LastDayOfYear Then
            Dim Year As Integer = CInt(Mid(GetPersianDate, 1, 4))
            If Year Mod 4 = 3 Then
                'sale kabise ast
                Me.txt = Year & "/12/30"
            Else
                'sale kabise nist
                Me.txt = Year & "/12/29"
            End If

        ElseIf Value = FirstDay.ToDay Then
            Me.txt = GetPersianDate()
        End If
    End Sub
    Enum FirstDay As Byte
        FirstDayOfMonth = 0
        FirstDayOfYear = 1
        LastDayOfMonth = 2
        LastDayOfYear = 3
        ToDay = 4
    End Enum

    Private Sub roz_TextChanged(sender As Object, e As EventArgs) Handles roz.TextChanged

    End Sub
End Class
