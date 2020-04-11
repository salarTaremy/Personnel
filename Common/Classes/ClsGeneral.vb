Public Class ClsGeneral
    Public Class Company
        Dim Dt_Company As New DataTable
        Dim Dialog As New UserControls.ClsDialog
        Dim DB As New DAL.ClsDataAccessLayer
        Public Sub New()
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "SELECT ID,CodeEghtesadi,Name,Detail FROM [Gn].[Company]"
            Dt_Company = Db.FillDataTable(cmd)
        End Sub
        Public Function GetAll() As DataTable
            Return Dt_Company
        End Function
        Public Sub AddNew(CodeEghtesadi As String, Name As String, Detail As String)
            Try
                Dim cmd As New SqlClient.SqlCommand
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[Gn].[UspAddCompany]"
                    .Parameters.AddWithValue("@CodeEghtesadi", CodeEghtesadi)
                    .Parameters.AddWithValue("@Name", Name)
                    .Parameters.AddWithValue("@Detail", Detail)
                End With
                If Db.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد")
                Else
                    Dialog.ShowInfo("ذخیره اطلاعات نا موفق")
                End If
            Catch ex As Exception
                Dialog.ShowErorr("ذخیره اطلاعات نا موفق")
            End Try
        End Sub
        Public Sub Update(Dt_Company As DataTable)
            Try
                Dim cmd As New SqlClient.SqlCommand
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[Gn].[UspUpdateCompany]"
                    .Parameters.AddWithValue("@Tbl", Dt_Company)
                End With
                If Db.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد")
                Else
                    Dialog.ShowInfo("ذخیره اطلاعات نا موفق")
                End If
            Catch ex As Exception
                Dialog.ShowErorr("ذخیره اطلاعات نا موفق")
            End Try
        End Sub
        Public Function Delete(ID As Integer) As Boolean
            Try
                If Dialog.ShowQuestion("برای حذف مطمئن هستید") = False Then
                    Return False
                End If
                Dim cmd As New SqlClient.SqlCommand
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[Gn].[UspDeleteCompany]"
                    .Parameters.AddWithValue("@ID", ID)
                End With
                If Db.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("حذف با موفقیت انجام شد")
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Dialog.ShowErorr("حذف این شرکت امکان پذیر نمیباشد")
                Return False
            End Try
        End Function
    End Class

End Class
