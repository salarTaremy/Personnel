Public Class FrmDllToDataBase

    Private Sub FrmDllToDataBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtPath.Text = Application.StartupPath
    End Sub
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim Ver As New ClsVersionControl
        If ChkExe.Checked Then
            Ver.AddApp(Me.TxtPath.Text.Trim)
        End If
        If ChkDal.Checked Then
            Dim inf As New DAL.ClsInformation
            Ver.AddLibrary("DAL", Me.TxtPath.Text.Trim, inf.Version)
        End If
        If ChkCom.Checked Then
            Dim inf As New Common.ClsInformation
            Ver.AddLibrary("Common", Me.TxtPath.Text.Trim, inf.Version)
        End If
        If ChkMain.Checked Then
            Dim Inf As New Main.ClsInformation
            Ver.AddLibrary("Main", Me.TxtPath.Text.Trim, Inf.Version)
        End If
        If ChkPrm.Checked Then
            Dim inf As New Permission.ClsInformation
            Ver.AddLibrary("Permission", Me.TxtPath.Text.Trim, inf.Version)
        End If
        If ChkUc.Checked Then
            Dim Inf As New UserControls.ClsInformation
            Ver.AddLibrary("UserControls", Me.TxtPath.Text.Trim, Inf.Version)
        End If
        If ChkTH.Checked Then
            Dim Inf As New TarafHesab.ClsInformation
            Ver.AddLibrary("TarafHesab", Me.TxtPath.Text.Trim, Inf.Version)
        End If
        If ChkPr.Checked Then
            Dim Inf As New Personnely.ClsInformation
            Ver.AddLibrary("Personnely", Me.TxtPath.Text.Trim, Inf.Version)
        End If
        If ChkSal.Checked Then
            Dim Inf As New Salary.ClsInformation
            Ver.AddLibrary("Salary", Me.TxtPath.Text.Trim, Inf.Version)
        End If
        If ChkEF.Checked Then
            Dim Inf As New EF.ClsInformation
            Ver.AddLibrary("EF", Me.TxtPath.Text.Trim, Inf.Version)
        End If
        If ChkGetExe.Checked Then
            Ver.GetApp(Me.TxtPath.Text.Trim)
        End If
    End Sub
End Class