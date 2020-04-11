Public Class RadTextBoxLimited
    Inherits UserControls.RadTextBox
    Dim ValidChar As String = "0123456789"
    Dim Alarm As Telerik.WinControls.UI.RadDesktopAlert
    Dim _NextObject As Telerik.WinControls.UI.RadTextBox
    'ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz_@#$%^&*()_+
    Public Property ValidCharacters As String
        Get
            Return Me.ValidChar
        End Get
        Set(value As String)
            Me.ValidChar = value
        End Set
    End Property
    Private Sub RadTextBoxNumberOnly_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(System.Windows.Forms.Keys.Back) Or e.KeyChar = Chr(System.Windows.Forms.Keys.Enter) Then
            e.Handled = False
        ElseIf ValidChar.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
            Alarm.CaptionText = "کاراکتر غیر مجاز"
            Alarm.ContentText = "شما  مجاز به استفاده از این کاراکترهاهستید:" & vbCrLf & ValidChar
            Alarm.ShowCloseButton = True
            Alarm.Show()
        End If
    End Sub

    Public Sub New()
        Alarm = New Telerik.WinControls.UI.RadDesktopAlert
        MyBase.NullText = "فقط عدد"
        MyBase.TextAlign = Windows.Forms.HorizontalAlignment.Center
    End Sub
    Private Sub Trs_LimitedTextBox_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        'جداسازی سه رقم
        'If MyBase.Text <> "" Then
        '    MyBase.Text = Format(MyBase.Text, Nothing)
        '    MyBase.Text = Format(CDbl(MyBase.Text), "##,0")
        '    MyBase.Select(MyBase.Text.Length, 1)
        'End If

    End Sub

    Private Sub RadTextBox_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Windows.Forms.Keys.Enter AndAlso Me.NextObject IsNot Nothing Then
            NextObject.Focus()
        End If
    End Sub


End Class
