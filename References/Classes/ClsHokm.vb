Public Class ClsHokm
    Public Structure Items
        Dim ID_Pr As Long
        Dim ID_Kargah As Integer
        Dim ID_EtekhdamType As Integer
        Dim ID_VahedKhedmat As Integer
        Dim ID_HokmType As Integer
        Dim ID_Job As Long
        Dim ID_Shift As Integer
        Dim DateEstekhdam As Integer
        Dim DateSodoor As Integer
        Dim DateStart As Integer
        Dim DateEnd As Integer
        Dim BasicSalaryPerMonthRls As Long
        Dim MabEzafeKarPerHour As Long
        Dim MabKasrKarPerHour As Long
        Dim MabOladRls As Long
        Dim MabMaskan As Long
        Dim MabBoneKargari As Long
        Dim Avamel As DataTable
    End Structure
    Public Function GetAll(Optional CodePersonneli As String = Nothing) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            Return Db.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetByID(ID As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokmByID]"
            cmd.Parameters.AddWithValue("@ID", ID)
            Return Db.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Delete(ID As Long) As Integer
        Try
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "Delete [Pr].[Hokm] WHERE ID = @ID"
                .Parameters.AddWithValue("@ID", ID)
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function DoLapse(ID As Long, Value As Boolean) As Integer
        Try
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Pr].[UspDoLapseHokm]"
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", ID)
                .Parameters.AddWithValue("@FlagLapse", Value)
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function AddNew(HokmItems As Items, Optional IDHokmForLapse As Long = 0) As Integer
        Try
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Pr].[UspAddHokm]"
                With .Parameters
                    .Clear()
                    .AddWithValue("@ID_Pr ", HokmItems.ID_Pr)
                    .AddWithValue("@ID_Hokm ", IDHokmForLapse)
                    .AddWithValue("@ID_Kargah", HokmItems.ID_Kargah)
                    .AddWithValue("@ID_EtekhdamType", HokmItems.ID_EtekhdamType)
                    .AddWithValue("@ID_VahedKhedmat", HokmItems.ID_VahedKhedmat)
                    .AddWithValue("@ID_HokmType", HokmItems.ID_HokmType)
                    .AddWithValue("@ID_Job", HokmItems.ID_Job)
                    .AddWithValue("@ID_Shift", HokmItems.ID_Shift)
                    .AddWithValue("@DateEstekhdam", HokmItems.DateEstekhdam)
                    .AddWithValue("@DateSodoor", HokmItems.DateSodoor)
                    .AddWithValue("@DateStart", HokmItems.DateStart)
                    .AddWithValue("@DateEnd", HokmItems.DateEnd)
                    .AddWithValue("@BasicSalaryPerMonthRls", HokmItems.BasicSalaryPerMonthRls)
                    .AddWithValue("@MabEzafeKarPerHour", HokmItems.MabEzafeKarPerHour)
                    .AddWithValue("@MabKasrKarPerHour", HokmItems.MabKasrKarPerHour)
                    .AddWithValue("@MabOladRls", HokmItems.MabOladRls)
                    .AddWithValue("@MabMaskan", HokmItems.MabMaskan)
                    .AddWithValue("@MabBoneKargari", HokmItems.MabBoneKargari)
                    .AddWithValue("@Avamel", HokmItems.Avamel)
                End With
            End With
            Return Db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Class Avamel
        Dim cmd As New SqlClient.SqlCommand
        Public Function GetAllInfo() As DataSet
            Try
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "[Pr].[UspGetAmelAllInformation]"
                Return Db.FillDataSet(cmd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete(ID As Integer) As Integer
            Try
                With cmd
                    .CommandType = CommandType.Text
                    .CommandText = "DELETE FROM [pr].[AvmeleHokmi] WHERE ID = @ID"
                    With .Parameters
                        .Clear()
                        .AddWithValue("@ID", ID)
                    End With
                    Return Db.ExecuteNonQuery(cmd)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function AddNew(Amel As Amel) As Integer
            Try
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[Pr].[UspAddAmelHokmi]"
                    With .Parameters
                        .Clear()
                        .AddWithValue("@ID_AmelType", Amel.ID_AmelType)
                        .AddWithValue("@ID_AmelCalculateMethod", Amel.ID_AmelCalculateMethod)
                        .AddWithValue("@ID_AmelBaseCalculate", Amel.ID_AmelBaseCalculate)
                        .AddWithValue("@Name", Amel.Name)
                        If Val(Amel.DefaultValue) > 0 Then
                            .AddWithValue("@DefaultValue", Amel.DefaultValue)
                        End If
                        .AddWithValue("@Priority", Amel.Priority)
                        .AddWithValue("@AlowChengeDefaultValue", Amel.AlowChengeDefaultValue)
                        .AddWithValue("@Insurance", Amel.Insurance)
                        .AddWithValue("@Taxable", Amel.Taxable)
                        .AddWithValue("@Detail", Amel.Detail)
                    End With
                End With
                Return Db.ExecuteNonQuery(cmd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetListOfAvamel(Optional IsForAtachHokm As Boolean = False, Optional IDHokm As Long = 0) As DataTable
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                If IsForAtachHokm Then
                    .CommandText = "[Pr].[UspGetListOfAvamelForAtachHokm]"
                    .Parameters.AddWithValue("@ID_HOKM", IDHokm)
                Else
                    .CommandText = "[Pr].[UspGetListOfAvamel]"
                End If
            End With
            Return Db.FillDataTable(cmd)
        End Function
        Public ReadOnly Property DefaultValues As DefaultVlues
            Get
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "[Pr].[UspGetListOfAvamelDefault]"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Year", SalMali)
                Dim Dt_Tmp As New DataTable
                Dt_Tmp = Db.FillDataTable(cmd)
                If Dt_Tmp.Rows.Count <= 0 Then
                    Return Nothing
                End If
                Dim ReturnValue As DefaultVlues
                With ReturnValue
                    .BasicSalaryPerMonthRls = Dt_Tmp.Rows(0).Item("BasicSalaryPerMonthRls")
                    .BasicSalaryPerDayRls = Dt_Tmp.Rows(0).Item("BasicSalaryPerMonthRls") / 30
                    .BasicSalaryPerHourRls = Dt_Tmp.Rows(0).Item("BasicSalaryPerMonthRls") / 220
                    .BonKargari = Dt_Tmp.Rows(0).Item("BonKargari")
                    .HaghMaskan = Dt_Tmp.Rows(0).Item("HaghMaskan")
                    .MaximumChild = Dt_Tmp.Rows(0).Item("MaximumChild")
                    .ZaribEzafeKar = Dt_Tmp.Rows(0).Item("ZaribEzafeKar")
                    .ZaribKasreKar = Dt_Tmp.Rows(0).Item("ZaribKasreKar")
                End With
                Return ReturnValue
            End Get
        End Property
        Public Function GetAllDefaultValues() As DataTable
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "[Pr].[UspGetListOfAvamelDefault]"
            cmd.Parameters.Clear()
            Return Db.FillDataTable(cmd)
        End Function
        Public Function UpdateDefaultValues(DtDefault As DataTable) As Integer
            Try
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "[Pr].[UspUpdateAvamelDefault]"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@NewAvamelDefault", DtDefault)
                Return Db.ExecuteNonQuery(cmd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Structure Amel
            Public ID_AmelType As Integer
            Public ID_AmelCalculateMethod As Integer
            Public ID_AmelBaseCalculate As Integer
            Public Name As String
            Public DefaultValue As Decimal
            Public Priority As Integer
            Public AlowChengeDefaultValue As Boolean
            Public Insurance As Boolean
            Public Taxable As Boolean
            Public Detail As String
        End Structure
        Public Structure DefaultVlues
            Public BasicSalaryPerMonthRls As Long
            Public BasicSalaryPerDayRls As Long
            Public BasicSalaryPerHourRls As Long
            Public ZaribEzafeKar As Decimal
            Public ZaribKasreKar As Decimal
            Public MaximumChild As Integer
            Public BonKargari As Long
            Public HaghMaskan As Long
        End Structure
    End Class
End Class
