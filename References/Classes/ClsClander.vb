Public Class ClsClander
    Dim cmd As New SqlClient.SqlCommand
    Public Function GetHoliDay(Year As Integer) As DataTable
        Try
            With cmd
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Cl].[UspGetHoliDay]"
                .Parameters.AddWithValue("@Year", Year)
            End With
            Return Db.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpdateHoliDay(Year As Integer, Dt_HoliDay As DataTable) As Integer
        Try
            With cmd
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Cl].[UspUpdateHoliday]"
                .Parameters.AddWithValue("@Year", Year)
                .Parameters.AddWithValue("@HoliDay", Dt_HoliDay)
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function DeleteHoliDay(HoliDayDate As String) As Integer
        Try
            With cmd
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Cl].[UspDeleteHoliDay]"
                .Parameters.AddWithValue("@Date", HoliDayDate)
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Class PersianDate
        Dim Dt_PersianDate As New DataTable
        Public Sub New(Persian_Date As Integer)
            Try
                Dim cmd As New SqlClient.SqlCommand
                With cmd
                    .CommandText = "[Cl].[UspGetInfoOfDay]"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@Persian_Date", Persian_Date)
                End With
                Dt_PersianDate = Db.FillDataTable(cmd)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function GetProperty(PropertyName As String) As Object
            'Vlid Parametrs : "Persian_Date","Gregorian_Date","DayOfWeek","Pr_DateDisplay","Gr_DateDisplay","Pr_Year","Gr_Year","Pr_Month","Gr_Month","Pr_Day","Gr_Day","Pr_Name","HolidayName","IsIntercalary"
            Try
                If Dt_PersianDate.Rows.Count = 0 Then
                    Return Nothing
                End If
                If Dt_PersianDate.Columns.Contains(PropertyName) Then
                    Return Me.Dt_PersianDate.Rows(0).Item(PropertyName)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Class
