Imports System.Data.SqlClient
Imports Microsoft.Win32
Module ModuleLogin
    Dim Path As String = "C:\Avandprg\" ' Application.StartupPath + "\"
    Dim FileName As String = "System.inf"
    Dim ID As String = "sa"
    Dim Password As String = "Ba2015th2"
    Dim ApplicationName As String = "Person"
    Dim IP As String = GetIp()
    'Public Conn1 As SqlConnection = New SqlConnection(" Data Source=" & IP & ";Initial Catalog=Personnel;Persist Security Info=True;User ID=" & ID & ";Password=" & Password & "")
    'Public Conn2 As SqlConnection = New SqlConnection(" Data Source=" & IP & ";Initial Catalog=PersonnelSystemDB;Persist Security Info=True;User ID=" & ID & ";Password=" & Password & "")
    Public Conn1 As SqlConnection = New SqlConnection(" Server=" & IP & ";Initial Catalog=Personnel;Persist Security Info=True;User ID=" & ID & ";Password=" & Password & ";Application Name=" & ApplicationName & ";")
    Public Conn2 As SqlConnection = New SqlConnection(" Server=" & IP & ";Initial Catalog=PersonnelSystemDB;Persist Security Info=True;User ID=" & ID & ";Password=" & Password & ";Application Name=" & ApplicationName & ";")
    Public Function GetIp() As String
        Try
            Dim Key As String
            Key = My.Computer.FileSystem.ReadAllText(Path + FileName)
            Select Case Key.Trim
                Case Is = "1"
                    Return "192.168.120.121"
                Case Is = "2"
                    Return "192.168.200.220"
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
                Case Is = "Manual"
                    Return GetManual()
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

    Private Function IsValidIp() As Boolean
        Try
            If My.Computer.Network.Ping(IP) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در تایید آی پی آدرس", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Return False
        End Try

    End Function
    Private Sub CheckConnection()
        Try
            If Not My.Computer.Network.IsAvailable Then
                MessageBox.Show("کامپیوتر شما به هیچ شبکه ای متصل نمیباشد", "خطا در اتصال به شبکه داده", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                End
            End If
            If Not IsValidIp() Then
                MessageBox.Show("Invalid Server IP Address", "خطا در اتصال به پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                End
            End If
            If TestConnection(Conn1) = False Then
                MessageBox.Show("امکان ارتباط با پایگاه داده اصلی برنامه میسر نمیباشد", "خطا در اتصال به پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                End
            Else
                RegisterKey("Connection1", Conn1.ConnectionString)
            End If
            Application.DoEvents()
            If TestConnection(Conn2) = False Then
                MessageBox.Show("امکان ارتباط با پایگاه داده سیستمی برنامه میسر نمیباشد", "خطا در اتصال به پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                End
            Else
                RegisterKey("Connection2", Conn2.ConnectionString)
            End If
        Catch ex As Exception
            MessageBox.Show("امکان بررسی کانکشن موجود  نمیباشد" & vbCrLf & ex.Message, "خطا ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End
        End Try
    End Sub
    Public Sub RegisterKey(Name As String, Value As String)
        Try
            Dim RK As RegistryKey
            RK = Registry.CurrentUser.OpenSubKey("Software", True)
            RK.CreateSubKey("Personel")
            RK = Registry.CurrentUser.OpenSubKey("Software\Personel", True)
            RK.SetValue(Name, Value)
            RK.Close()
        Catch ex As Exception
            MessageBox.Show("امکان نوشتن اطلاعات در رجیستری نمیباشد" & vbCrLf & ex.Message, "خطا ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End
        End Try
    End Sub
    Private Function GetManual() As String
        ID = InputBox("Enter Database Login Name:", "ID", "sa")
        Password = InputBox("Enter Database Password:")
        Return InputBox("Enter IP:")
    End Function
End Module
