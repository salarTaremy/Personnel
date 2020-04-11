Public Class FrmAddStiReport
    Public RepName As String = Nothing
    Public COUNTER As Integer = 0
    Private Sub FrmAddStiReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCmb()
    End Sub
    Private Sub FillCmb()
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT 0 AS [COUNTER] ,N'فرمت جدید(خام)' AS NAME UNION ALL SELECT COUNTER ,ReportName  FROM [StiReport].[dbo].ReportFiles WHERE FormName = 'SampleFormat' ORDER BY [COUNTER] "
        cmd.CommandType = CommandType.Text
        Me.CmbFormat.DataSource = DB.FillDataTable(cmd)
        Me.CmbFormat.ListElement.Font = New System.Drawing.Font("tahoma", 8.25)
        Me.CmbFormat.DisplayMember = "NAME"
        Me.CmbFormat.ValueMember = "COUNTER"
        Me.CmbFormat.SelectedIndex = 0
    End Sub
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If String.IsNullOrEmpty(Me.TxtName.Text.Trim) Then
            Dialog.ShowInfo("نام گزارش نا معتبر است")
            Exit Sub
        End If
        Me.COUNTER = CmbFormat.SelectedValue
        Me.RepName = Me.TxtName.Text.Trim
        Me.Close()
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub
End Class