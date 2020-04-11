Public Class FrmStiDesigner
    Public Rep As Stimulsoft.Report.StiReport
    Public CounterOfReport As String
    Private Sub FrmStiDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Designer.Report = Rep
    End Sub
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Update(Me.Designer.Report, Me.CounterOfReport)
    End Sub
    Private Sub Update(Report As Stimulsoft.Report.StiReport, Counter As String)
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update [PersonnelSystemDB]..ReportFiles set Value =  @val  where counter = @Counter "
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@val", Report.SaveToByteArray)
            cmd.Parameters.AddWithValue("@Counter", Counter.Trim)
            DB.ExecuteNonQuery(cmd)
            Dialog.ShowOK("گزارش   در دیتا بیس ذخیره شد")
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Sub
End Class