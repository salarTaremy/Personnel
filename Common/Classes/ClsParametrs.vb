Public Class ClsParametrs
    Dim cmd As New SqlClient.SqlCommand
    Public Function GetAll() As DataTable
        Try
            With cmd
                .Parameters.Clear()
                .CommandText = "[Gn].[UspGetParametrs]"
                .CommandType = CommandType.StoredProcedure
            End With
            Return Db.FillDataTable(cmd)
        Catch ex As Exception
            Dialog.ShowErorr("خطا در خواندن پارامتر", ex.Message)
            Throw ex
        End Try
    End Function
    Public Function GetValue(ID As Long) As String
        Try
            With cmd
                .Parameters.Clear()
                .CommandText = "[Gn].[UspGetParametrs]"
                .Parameters.AddWithValue("@ID", ID)
                .CommandType = CommandType.StoredProcedure
            End With
            Return Db.FillDataTable(cmd).Rows(0).Item("Value")
        Catch ex As Exception
            Dialog.ShowErorr("خطا در خواندن پارامتر", ex.Message)
            Throw ex
        End Try
    End Function
    Public Function Update(TblItems As DataTable) As Integer
        Try
            With cmd
                .Parameters.Clear()
                .CommandText = "[Gn].[UspUpdateParametrs]"
                .Parameters.AddWithValue("@Items", TblItems)
                .CommandType = CommandType.StoredProcedure
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Dialog.ShowErorr("خطا در خواندن پارامتر", ex.Message)
            Throw ex
        End Try
    End Function

End Class
