Imports System.Windows.Forms

Public Class FrmConnectToSql
    Public Connection As SqlClient.SqlConnection
    Private Sub FrmConnectToSql_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CmbType.SelectedIndex = 0
        Me.CmbAuthentication.SelectedIndex = 0
        Me.CmbName.Focus()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Connection = Nothing
        Me.Close()
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        Connect()
    End Sub
    Public Sub Connect()
        Try
            Dim IP As String = CmbName.Text.Trim
            Dim ID As String = CmbLogin.Text.Trim
            Dim Pass As String = TxtPass.Text.Trim
            Dim CnStr As String = " Data Source=" & IP & ";Persist Security Info=True;User=" & ID & ";Password=" & Pass
            Connection = New SqlClient.SqlConnection(CnStr)
            Connection.Open()
            Connection.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro Connecting To Server", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Connect()
        End If
    End Sub
End Class