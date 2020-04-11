Public Class ClsPersonBase
    Dim cmd As New SqlClient.SqlCommand
    'Public Function GetAllSalMali() As DataTable
    '    Try
    '        With cmd
    '            .Parameters.Clear()
    '            .CommandType = CommandType.Text
    '            .CommandText = "SELECT ID, [Year] FROM Pr.AvamelDefault ORDER BY [Year] Desc"
    '            Return Db.FillDataTable(cmd)
    '        End With
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
    Public Class Kargah
        Dim Dt_Kargah As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        Public Sub New()
            cmd.Parameters.Clear()
            cmd.CommandText = "[PR].[UspGetKargah]"
            cmd.CommandType = CommandType.StoredProcedure
            Dt_Kargah = Db.FillDataTable(cmd)
        End Sub
        Public Sub New(ID? As Long)
            cmd.Parameters.Clear()
            cmd.CommandText = "[PR].[UspGetKargah]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("ID", ID)
            Dt_Kargah = DB.FillDataTable(cmd)
        End Sub
        Public Sub New(CodeKargah As String)
            cmd.Parameters.Clear()
            cmd.CommandText = "[PR].[UspGetKargah]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("CodeKargah", CodeKargah)
            Dt_Kargah = DB.FillDataTable(cmd)
        End Sub
        Public ReadOnly Property ID() As Long
            Get
                Return CLng(Dt_Kargah.Rows(0).Item("ID"))
            End Get
        End Property

        Public ReadOnly Property RadifPeyman() As String
            Get
                Return Dt_Kargah.Rows(0).Item("RadifPeyman").ToString
            End Get
        End Property
        Public ReadOnly Property ID_Company() As Long
            Get
                Return Dt_Kargah.Rows(0).Item("ID_Company").ToString
            End Get
        End Property
        Public ReadOnly Property CompanyName() As String
            Get
                Return Dt_Kargah.Rows(0).Item("CompanyName").ToString
            End Get
        End Property
        Public ReadOnly Property CodeKargah() As String
            Get
                Return Dt_Kargah.Rows(0).Item("CodeKargah").ToString
            End Get
        End Property
        Public ReadOnly Property Name() As String
            Get
                Return Dt_Kargah.Rows(0).Item("Name").ToString
            End Get
        End Property
        Public ReadOnly Property Detail() As String
            Get
                Return Dt_Kargah.Rows(0).Item("Detail").ToString
            End Get
        End Property
        Public Function GetAll() As DataTable
            Return Dt_Kargah
        End Function
        Public Function GetAll(ID_Company As Byte) As DataTable
            Dim Tmp = Dt_Kargah.AsEnumerable.Where(Function(x) x.Field(Of Byte)("ID_Company") = ID_Company Or x.Field(Of Byte)("ID_Company") = 0)
            Return Tmp.CopyToDataTable()
        End Function
        Public Sub AddNew(Code As Long, Name As String, Detail As String, RadifPeyman As String, ID_Company As Long)
            Try
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Pr.UspAddKargah"
                    .Parameters.AddWithValue("@Code", Code)
                    .Parameters.AddWithValue("@Name", Name)
                    .Parameters.AddWithValue("@RadifPeyman", RadifPeyman)
                    .Parameters.AddWithValue("@ID_Company", ID_Company)
                    .Parameters.AddWithValue("@Detail", Detail)
                End With
                If DB.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد")
                Else
                    Dialog.ShowInfo("ذخیره اطلاعات نا موفق")
                End If
            Catch ex As Exception
                Dialog.ShowErorr("ذخیره اطلاعات نا موفق")
            End Try
        End Sub
        Public Sub Update(Dt_Kargah As DataTable)
            Try
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[Pr].[UspUpdateKargah]"
                    .Parameters.AddWithValue("@Tbl", Dt_Kargah)
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
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Pr.UspDeleteKargah"
                    .Parameters.AddWithValue("@ID", ID)
                End With
                If Db.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("حذف با موفقیت انجام شد")
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Dialog.ShowErorr("حذف این کارگاه امکان پذیر نمیباشد")
                Return False
            End Try
        End Function
    End Class
    Public Class VahedKhedmat
        Dim Dt_VahedKhedmat As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        Public Sub New()
            cmd.Parameters.Clear()
            cmd.CommandText = "SELECT  ID,Name,Detail FROM [Pr].[VahedKhedmat]"
            Dt_VahedKhedmat = Db.FillDataTable(cmd)
        End Sub
        Public Function GetAll() As DataTable
            Return Dt_VahedKhedmat
        End Function
        Public Sub AddNew(Name As String, Detail As String)
            Try
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Pr.[UspAddVahedKhedmat]"
                    .Parameters.AddWithValue("@Name", Name)
                    .Parameters.AddWithValue("@Detail", Detail)
                End With
                If Db.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد")
                End If
            Catch ex As Exception
                Dialog.ShowErorr("ذخیره اطلاعات نا موفق")
            End Try
        End Sub
        Public Sub Update(Dt_Vahed As DataTable)
            Try
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[Pr].[UspUpdateVahedKhedmat]"
                    .Parameters.AddWithValue("@Tbl", Dt_Vahed)
                End With
                If Db.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد")
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
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Pr.[UspDeleteVahedKhedmat]"
                    .Parameters.AddWithValue("@ID", ID)
                End With
                If Db.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("حذف با موفقیت انجام شد")
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Dialog.ShowErorr("حذف این کارگاه امکان پذیر نمیباشد")
                Return False
            End Try
        End Function
    End Class
    Public Class MahaleKhedmat
        Dim cmd As New SqlClient.SqlCommand()
        Public Function GetAll() As DataTable
            Try
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Pr.UspGetMahaleKhedmat"
                End With
                Return DB.FillDataTable(cmd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
    Public Class EstekhdamTypes
        Dim Dt_EstekhdamTypes As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        Public Sub New()
            cmd.Parameters.Clear()
            cmd.CommandText = "SELECT ID,Name,Detail FROM[Pr].[EstekhdamTypes]"
            Dt_EstekhdamTypes = Db.FillDataTable(cmd)
        End Sub
        Public Sub AddNew(Name As String, Detail As String)
            Try
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Pr.UspAddEstekhdamType"
                    .Parameters.AddWithValue("@Name", Name)
                    .Parameters.AddWithValue("@Detail", Detail)
                End With
                If Db.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد")
                End If
            Catch ex As Exception
                Dialog.ShowErorr("ذخیره اطلاعات نا موفق")
            End Try
        End Sub
        Public Sub Update(Dt_Estekhdam As DataTable)
            Try
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[Pr].[UspUpdateEstekhdamType]"
                    .Parameters.AddWithValue("@Tbl", Dt_Estekhdam)
                End With
                If Db.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد")
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
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Pr.UspDeleteEstekhdamType"
                    .Parameters.AddWithValue("@ID", ID)
                End With
                If Db.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("حذف با موفقیت انجام شد")
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Dialog.ShowErorr("حذف این نوع امکان پذیر نمیباشد")
                Return False
            End Try
        End Function
        Public Function GetAll() As DataTable
            Return Dt_EstekhdamTypes
        End Function
    End Class
    Public Class DayOfWeek
        Dim cmd As New SqlClient.SqlCommand
        Public Function GetDays(ID_Shift As Integer) As DataTable
            Try
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[Pr].[UspGetShiftsDetail]"
                    .Parameters.AddWithValue("@ID_Shift", ID_Shift)
                End With
                Return Db.FillDataTable(cmd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update(ID_SHIFT As Integer, ShiftsDetail As DataTable) As Integer
            Try
                With cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@ID_SHIFT", ID_SHIFT)
                    .Parameters.AddWithValue("@ShiftsDetail", ShiftsDetail)
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[pr].[UspUpdateShiftDetails]"
                End With
                Return Db.ExecuteNonQuery(cmd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetAllShifts() As DataTable
            Try
                With cmd
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[Pr].[UspGetAllShifts]"
                End With
                Return Db.FillDataTable(cmd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
End Class
