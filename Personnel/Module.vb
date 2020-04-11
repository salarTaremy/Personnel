Imports System.Data.SqlClient
Module ModuleReferences
    Dim IP As String = GetIp()
    Public Conn1 = New SqlConnection(" Data Source=" & IP & ";Initial Catalog=Personnel;Persist Security Info=True;User ID=sa;Password=Ba2015th2 ")
    Public Conn2 = New SqlConnection(" Data Source=" & IP & ";Initial Catalog=PersonnelSystemDB;Persist Security Info=True;User ID=sa;Password=Ba2015th2")
    Public Function GetIp() As String
        Try
            Dim Key As String
            Key = My.Computer.FileSystem.ReadAllText("C:\Avandprg\System.inf")
            'Key = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\System.inf")
            Select Case Key.Trim
                Case Is = "1"
                    Return "192.168.120.121"
                Case Is = "2"
                    Return "192.168.200.15"
                Case Is = "3"
                    Return "192.168.200.121"
                Case Is = "4"
                    Return "192.168.200.121"
                Case Is = "5"
                    Return "192.168.200.121"
                Case Is = "6"
                    Return "192.168.200.121"
                Case Is = "7"
                    Return "192.168.200.121"
                Case Is = "8"
                    Return "192.168.200.121"
                Case Is = "9"
                    Return "192.168.200.121"
                Case Else
                    MessageBox.Show("ای پی نا معتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    End
            End Select
        Catch ex As Exception
            MessageBox.Show("خطا در خواند فایل سیستمی" & vbCrLf & ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End
        End Try
    End Function
    Public Function TestConnection(Connection As SqlClient.SqlConnection) As Boolean
        Try
            Connection.Open()
            Connection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub Main()
        CheckConnection()
        Application.DoEvents()
        '''''''''''''''''''''''''''''''''''''''''
        Try
            Dim UpDateApp As New ClsUpdateApp
            UpDateApp.UpdateApp()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در عملیات بروز رسانی", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        End Try
    End Sub


    Private Sub CheckConnection()
        If TestConnection(Conn1) = False Then
            MessageBox.Show("امکان ارتباط با پایگاه داده اصلی برنامه میسر نمیباشد", "خطا در اتصال به پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End
        End If
        Application.DoEvents()
        If TestConnection(Conn2) = False Then
            MessageBox.Show("امکان ارتباط با پایگاه داده سیستمی برنامه میسر نمیباشد", "خطا در اتصال به پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End
        End If
    End Sub
End Module
