Public Class FrmSplashScreenLoading
    Dim MyCaption As String

    Public Sub New(Optional Caption As String = Nothing)
        MyCaption = Caption
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub FrmSplashScreenLoading_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.LblFrmName.Text = MyCaption
    End Sub
End Class