Public Class RadTextBox
    Inherits Telerik.WinControls.UI.RadTextBox
    Private _NextObject As Telerik.WinControls.UI.RadTextBox = Nothing
    Private _IsRequired As Boolean = False
    Private _Name_Farsi As String
    Private _FocusColor As System.Drawing.Color = Drawing.Color.Azure
    Public Sub New()
        MyBase.TextAlign = Windows.Forms.HorizontalAlignment.Center
    End Sub
    Public Sub Setfocus() Handles MyBase.GotFocus
        MyBase.Select(0, MyBase.Text.Length)
        MyBase.BackColor = Me.FocusColor
    End Sub
    Public Sub Lost_Focus() Handles MyBase.LostFocus
        MyBase.BackColor = Drawing.Color.White
    End Sub
    Public Property NextObject As Telerik.WinControls.UI.RadTextBox
        Get
            Return _NextObject
        End Get
        Set(value As Telerik.WinControls.UI.RadTextBox)
            _NextObject = value
        End Set
    End Property
    Private Sub RadTextBox_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Windows.Forms.Keys.Enter AndAlso Me.NextObject IsNot Nothing Then
            NextObject.Focus()
        End If
    End Sub
    Public Property IsRequierd As Boolean
        Get
            Return _IsRequired
        End Get
        Set(ByVal value As Boolean)
            _IsRequired = value
            If MyBase.NullText = Nothing Then
                If value = True Then
                    MyBase.NullText = "الزامی"
                Else
                    MyBase.NullText = Nothing
                End If
            End If
        End Set
    End Property
    Public Property Name_Farsi As String
        Get
            Return _Name_Farsi
        End Get
        Set(ByVal value As String)
            _Name_Farsi = value
        End Set
    End Property
    Public Property FocusColor As System.Drawing.Color
        Get
            Return _FocusColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            _FocusColor = value
        End Set
    End Property
    Public Overrides Property Text As String
        Get
            Return MyBase.Text.Replace("ي", "ی").Replace("ك", "ک")
        End Get
        Set(value As String)
            MyBase.Text = value
        End Set
    End Property
End Class
