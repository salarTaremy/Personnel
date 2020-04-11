Public Class FrmDllToDataBase

    Private Sub FrmDllToDataBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtPath.Text = Application.StartupPath
    End Sub
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim Ver As New ClsVersionControl
        If ChkExe.Checked Then
            Ver.AddApp(Me.TxtPath.Text.Trim)
        End If
        If ChkRef.Checked Then
            Dim inf As New References.ClsInformation
            Ver.AddLibrary("References", Me.TxtPath.Text.Trim, inf.Version)
        End If
        If ChkUc.Checked Then
            Dim inf As New UserControls.ClsInformation
            Ver.AddLibrary("UserControls", Me.TxtPath.Text.Trim, inf.Version)
        End If
        If ChkRes.Checked Then
            Dim Inf As New Resource.ClsInformation
            Ver.AddLibrary("Resource", Me.TxtPath.Text.Trim, Inf.Version)
        End If
        If ChkGetExe.Checked Then
            Ver.GetApp(Me.TxtPath.Text.Trim)
        End If
    End Sub
End Class