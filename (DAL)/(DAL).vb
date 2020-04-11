Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms
Imports Microsoft.Win32
Public Class ClsDataAccessLayer
    Dim Conn1 As SqlConnection
    Dim Conn2 As SqlConnection
    Dim Da As New SqlDataAdapter
    Dim DT As New DataTable
    Dim RK As RegistryKey
    Dim CommandTimeout As Integer = 2147483647   'per seccond
    Public Sub New(Optional Connection As SqlConnection = Nothing)
        Try
            RK = Registry.CurrentUser.OpenSubKey("Software\Personel", True)
            Dim CnString1 As String = RK.GetValue("Connection1")
            Dim CnString2 As String = RK.GetValue("Connection2")
            CnString1 &= GetAppName()
            Conn1 = New SqlConnection(CnString1)
            Conn2 = New SqlConnection(CnString2)
            If Connection IsNot Nothing Then
                Conn1 = Connection
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Function GetAppName() As String
        Try
            Dim User_Name As String = RK.GetValue("User_Name")
            Dim AppName As String = "; Application Name = "
            AppName &= " PcName:" & My.Computer.Name
            'AppName &= " IP:" & Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList(1).ToString ' System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0).ToString
            AppName &= " IP:" & System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0).ToString()
            AppName &= " UserName:" & User_Name
            Return AppName
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function GetConnection(Optional IsSystemDataBase As Boolean = False) As SqlConnection
        Try
            If IsSystemDataBase = True Then
                If Conn2.State = ConnectionState.Closed Then
                    Conn2.Open()
                End If
                Return Conn2
            End If
            If Conn1.State = ConnectionState.Closed Then
                Conn1.Open()
            End If
            Return Conn1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "امکان اتصال به پایگاه داده وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Throw ex
        End Try
    End Function
    Public Function ExecuteNonQuery(SQlCommand As SqlCommand, Optional IsSystemDataBase As Boolean = False) As Integer
        Try
            Dim RowAffected As Integer = -1
            SQlCommand.Connection = GetConnection(IsSystemDataBase)
            Cursor.Current = Cursors.WaitCursor
            RowAffected = SQlCommand.ExecuteNonQuery
            Cursor.Current = Cursors.Default
            SQlCommand.Connection.Close()
            SQlCommand.CommandTimeout = CommandTimeout
            Return RowAffected
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Dim cr As New ClsErrorHandler(ex)
            cr.ToPersian()
            Return 0
        End Try
    End Function
    Public Function ExecuteScalar(SQlCommand As SqlCommand, Optional IsSystemDataBase As Boolean = False) As Object
        Try
            Dim OBJ As Object = -1
            SQlCommand.Connection = GetConnection(IsSystemDataBase)
            Cursor.Current = Cursors.WaitCursor
            OBJ = SQlCommand.ExecuteScalar
            Cursor.Current = Cursors.Default
            SQlCommand.Connection.Close()
            SQlCommand.CommandTimeout = CommandTimeout
            Return OBJ
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Dim cr As New ClsErrorHandler(ex)
            cr.ToPersian()
            Return Nothing
        End Try
    End Function
    Public Function FillDataTable(SQlCommand As SqlCommand, Optional IsSystemDataBase As Boolean = False) As DataTable
        Try
            Dim Da As New SqlDataAdapter
            Dim DT As New DataTable
            SQlCommand.Connection = GetConnection(IsSystemDataBase)
            SQlCommand.CommandTimeout = CommandTimeout
            Da = New SqlDataAdapter(SQlCommand)
            DT = New DataTable
            Cursor.Current = Cursors.WaitCursor
            Da.Fill(DT)
            Cursor.Current = Cursors.Default
            SQlCommand.Connection.Close()
            Return DT
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Dim cr As New ClsErrorHandler(ex)
            cr.ToPersian()
            Return Nothing
        End Try
    End Function
    Public Function FillDataSet(SQlCommand As SqlCommand, Optional IsSystemDataBase As Boolean = False) As DataSet
        Try
            Dim Da As New SqlDataAdapter
            Dim Ds As New DataSet
            SQlCommand.Connection = GetConnection(IsSystemDataBase)
            SQlCommand.CommandTimeout = CommandTimeout
            Da = New SqlDataAdapter(SQlCommand)
            DT = New DataTable
            Cursor.Current = Cursors.WaitCursor
            Da.Fill(Ds)
            Cursor.Current = Cursors.Default
            SQlCommand.Connection.Close()
            Return Ds
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Dim cr As New ClsErrorHandler(ex)
            cr.ToPersian()
            Return Nothing
        End Try
    End Function
End Class
