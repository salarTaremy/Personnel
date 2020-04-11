Public Class ClsPersonnelWork
    Dim cmd As New SqlClient.SqlCommand
    Dim MyConnection As SqlClient.SqlConnection
    Dim PwKaraDb As ClsDataAccessLayer
    Public Function AddPersonnelWork(PersonnelWork As DataTable, Optional StartDate As String = Nothing, Optional EndDate As String = Nothing, Optional PersonCode1 As String = Nothing, Optional PersonCode2 As String = Nothing) As Integer
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Pr].[UspAddPersonnelWork]"
                .Parameters.Clear()
                If Not StartDate = Nothing Then
                    .Parameters.AddWithValue("@StartDate", StartDate)
                End If
                If Not StartDate = Nothing Then
                    .Parameters.AddWithValue("@EndDate", EndDate)
                End If
                If Not PersonCode1 = Nothing Then
                    .Parameters.AddWithValue("@PersonCode1", PersonCode1)
                End If
                If Not PersonCode2 = Nothing Then
                    .Parameters.AddWithValue("@PersonCode2", PersonCode2)
                End If
                .Parameters.AddWithValue("@PersonnelWork", PersonnelWork)
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function AddPersonnelWorkManual(PersonnelCode As String, PersianDate As Integer, Time As String, Action As Integer) As Integer
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Pr].[UspAddPersonnelWorkManual]"
                .Parameters.Clear()
                .Parameters.AddWithValue("@PersonnelCode", PersonnelCode)
                .Parameters.AddWithValue("@Date", PersianDate)
                .Parameters.AddWithValue("@time", Time)
                .Parameters.AddWithValue("@Action", Action)
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function DeletePersonnelWork(Optional StartDate As String = Nothing, Optional EndDate As String = Nothing, Optional PersonCode1 As String = Nothing, Optional PersonCode2 As String = Nothing) As Integer
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Pr].[UspDeletePersonnelWork]"
                .Parameters.Clear()
                If Not StartDate = Nothing Then
                    .Parameters.AddWithValue("@StartDate", StartDate)
                End If
                If Not StartDate = Nothing Then
                    .Parameters.AddWithValue("@EndDate", EndDate)
                End If
                If Not PersonCode1 = Nothing Then
                    .Parameters.AddWithValue("@PersonCode1", PersonCode1)
                End If
                If Not PersonCode2 = Nothing Then
                    .Parameters.AddWithValue("@PersonCode2", PersonCode2)
                End If
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ViewPersonnelWorkFromDevice(Optional StartDate As String = Nothing, Optional EndDate As String = Nothing, Optional PersonCode1 As String = Nothing, Optional PersonCode2 As String = Nothing, Optional JustView As Boolean = True) As DataTable
        Try
            With cmd
                .CommandType = CommandType.Text
                .CommandText = Me.StringReadFromPWKara
                .Parameters.Clear()
                .Parameters.AddWithValue("@StartDate", IsNothing(StartDate, DBNull.Value))
                .Parameters.AddWithValue("@EndDate", IsNothing(EndDate, DBNull.Value))
                .Parameters.AddWithValue("@Emp_No1", IsNothing(PersonCode1, DBNull.Value))
                .Parameters.AddWithValue("@Emp_No2", IsNothing(PersonCode2, DBNull.Value))
            End With
            Return PwKaraDb.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ViewAddPersonnelWorkFromDevice(PwkaraDataFile As DataTable) As Integer
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[pr].[UspAddPersonWorkFromDevice]"
                .Parameters.Clear()
                .Parameters.AddWithValue("@PwkaraDataFile", PwkaraDataFile)
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ViewWorkPerDay(StartDate As Integer, EndDate As Integer, PersonCode As String, Optional ViewLaps As Boolean = False) As DataTable
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Pr].[UspGetWorkPerDay]"
                .Parameters.Clear()
                .Parameters.AddWithValue("@StartDate", StartDate)
                .Parameters.AddWithValue("@EndDate", EndDate)
                .Parameters.AddWithValue("@PersonCode", PersonCode)
                .Parameters.AddWithValue("@ViewLaps", ViewLaps)
            End With
            Return Db.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetDefectiveWorks(StartDate As Integer, EndDate As Integer, PersonCode As String) As DataTable
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Pr].[UspGetDefectiveWorks]"
                .Parameters.Clear()
                .Parameters.AddWithValue("@StartDate", StartDate)
                .Parameters.AddWithValue("@EndDate", EndDate)
                .Parameters.AddWithValue("@PersonCode", IsNothing(PersonCode, DBNull.Value))
            End With
            Return Db.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function DeletePersonWorkPerDay(Counter As Long) As Integer
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[PR].[UspDeletePersonnelWorkPerDay]"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Counter", Counter)
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpdateLapseOfPersonWorkPerDay(Counter As Long, FlagLaps As Boolean) As Integer
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[PR].[UspUpdateLapseOfPrWorkPerDay]"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Counter", Counter)
                .Parameters.AddWithValue("@FalagLapse", FlagLaps)
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetAllActions() As DataTable
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Pr].[UspGetAllActions]"
                .Parameters.Clear()
            End With
            Return Db.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetAllDbName() As DataTable
        Try
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT database_id ID, Name FROM sys.databases"
                .Parameters.Clear()
            End With
            Return PwKaraDb.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub New(Optional ConnectionString As SqlClient.SqlConnection = Nothing)
        If ConnectionString IsNot Nothing Then
            MyConnection = ConnectionString
            PwKaraDb = New ClsDataAccessLayer(MyConnection, Nothing)
        End If

    End Sub
    Private ReadOnly Property StringReadFromPWKara As String
        Get
            Dim TmpStrimg As String = Nothing
            TmpStrimg &= vbCrLf & "DECLARE @Date1 FLOAT   = DATEDIFF(DAY,CAST('18991230' AS date),CAST(@StartDate AS DATE))"
            TmpStrimg &= vbCrLf & "DECLARE @Date2 FLOAT   = DATEDIFF(DAY,CAST('18991230' AS date),CAST(@EndDate AS DATE))"
            TmpStrimg &= vbCrLf & "SELECT  "
            TmpStrimg &= vbCrLf & "			 [EMP_NO]		=	PWK.EMP_No"
            TmpStrimg &= vbCrLf & "			,[Date]			=	CAST(FORMAT(DATEADD(DAY,-2,PWK.DATE_),'yyyyMMdd') AS INT)"
            TmpStrimg &= vbCrLf & "			,[Time]			=	CAST(REPLACE(LEFT(RIGHT('0'+CAST(PWK.TIME_ AS NVARCHAR) ,4),2) + ':' +RIGHT(CAST(PWK.TIME_ AS NVARCHAR),2),'24:','00:') As Time(0))"
            TmpStrimg &= vbCrLf & "			--,[EMP_Name]		=	EMP.NAME + ' ' + EMP.FAMILY"
            TmpStrimg &= vbCrLf & "			,[Action]		=	PWK.STATUS "
            TmpStrimg &= vbCrLf & "FROM  pwkara..DataFile	PWK"
            TmpStrimg &= vbCrLf & "INNER JOIN  pwkara..EMPLOYEE EMP"
            TmpStrimg &= vbCrLf & "	ON Emp.EMP_NO = PWK.EMP_NO"
            TmpStrimg &= vbCrLf & "WHERE  1=1"
            TmpStrimg &= vbCrLf & "AND  PWK.DATE_ >= @Date1"
            TmpStrimg &= vbCrLf & "AND  PWK.DATE_ <= @Date2"
            TmpStrimg &= vbCrLf & "AND EMP.EMP_NO BETWEEN ISNULL(@Emp_No1,0) AND ISNULL(@Emp_No2 , (SELECT MAX(EMP_NO) FROM pwkara..EMPLOYEE))"
            Return TmpStrimg
        End Get
    End Property
End Class
