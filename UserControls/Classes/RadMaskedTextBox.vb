Public Class RadMaskedTextBox
    Inherits Telerik.WinControls.UI.RadMaskedEditBox
    Dim _NextObject As Telerik.WinControls.UI.RadTextBox
    Public Sub New()
        MyBase.MaskType = Telerik.WinControls.UI.MaskType.Numeric
    End Sub
    Public ReadOnly Property Rls As Long
        Get
            Return Replace(MyBase.Text, ",", "")
        End Get
    End Property
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

End Class
