Imports System.Data.SqlClient
Public Class ClsDataAccessLayer
    Dim Conn1 = New SqlConnection
    Dim Conn2 = New SqlConnection
    Dim Da As New SqlDataAdapter
    Dim DT As New DataTable
    Public Sub New(Optional Connection1 As SqlConnection = Nothing, Optional Connection2 As SqlConnection = Nothing)
        Conn1 = Connection1
        Conn2 = Connection2
    End Sub
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
            Dialog.ShowErorr("امکان اتصال به پایگاه داده وجود ندارد", ex.Message)
            Throw ex
        End Try
    End Function
    Public Function ExecuteNonQuery(SQlCommand As SqlCommand, Optional IsSystemDataBase As Boolean = False) As Integer
        Try
            Dim RowAffected As Integer = -1
            SQlCommand.Connection = GetConnection(IsSystemDataBase)
            RowAffected = SQlCommand.ExecuteNonQuery
            SQlCommand.Connection.Close()
            SQlCommand.CommandTimeout = 99999999
            Return RowAffected
        Catch ex As Exception
            Dim cr As New ClsErrorHandler(ex)
            cr.ToPersian()
            Return 0
        End Try
    End Function
    Public Function ExecuteScalar(SQlCommand As SqlCommand, Optional IsSystemDataBase As Boolean = False) As Object
        Try
            Dim OBJ As Object = -1
            SQlCommand.Connection = GetConnection(IsSystemDataBase)
            OBJ = SQlCommand.ExecuteScalar
            SQlCommand.Connection.Close()
            Return OBJ
        Catch ex As Exception
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
            Da = New SqlDataAdapter(SQlCommand)
            DT = New DataTable
            Da.Fill(DT)
            SQlCommand.Connection.Close()
            Return DT
        Catch ex As Exception
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
            Da = New SqlDataAdapter(SQlCommand)
            DT = New DataTable
            Da.Fill(Ds)
            SQlCommand.Connection.Close()
            Return Ds
        Catch ex As Exception
            Dim cr As New ClsErrorHandler(ex)
            cr.ToPersian()
            Return Nothing
        End Try
    End Function

End Class
