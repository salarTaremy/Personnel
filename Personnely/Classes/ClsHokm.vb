Public Class ClsHokm
    Public Structure Items
        Dim ID_Pr As Long
        Dim ID_Kargah As Integer
        Dim ID_EtekhdamType As Integer
        Dim ID_VahedKhedmat As Integer
        Dim ID_MahaleKhedmat As Short
        Dim ID_MahaleKhedmatStatus As Byte
        Dim ID_HokmType As Integer
        Dim ID_Job As Long
        Dim ID_Shift As Integer
        Dim ID_ContractType As Byte
        Dim ID_InsuranceType As Byte
        Dim DateEstekhdam As Integer
        Dim DateSodoor As Integer
        Dim DateStart As Integer
        Dim DateEnd As Integer
        Dim BasicSalaryPerMonthRls As Long
        Dim MabEzafeKarPerHour As Long
        Dim MabKasrKarPerHour As Long
        Dim MabShabKariPerHour As Long
        Dim MabTatilKariPerHour As Long
        Dim ZaribEzafeKarPerHour As Decimal
        Dim ZaribKasrKarPerHour As Decimal
        Dim ZaribShabKariPerHour As Decimal
        Dim ZaribTatilKariPerHour As Decimal
        Dim MabOladRls As Long
        Dim MabMaskan As Long
        Dim MabBoneKargari As Long
        Dim PayeSanavat As Integer
        Dim Avamel As DataTable
    End Structure
    'OverLoad0
    Public Function GetAll() As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad1
    Public Function GetAll(CodePersonneli As String) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad2
    Public Function GetAll(CodePersonneli As String, OnlyActive As Boolean) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@OnlyActive", OnlyActive)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad3
    Public Function GetAll(CodePersonneli As String, OnlyActive As Boolean, ID_MahaleKhedmat As Short) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@OnlyActive", OnlyActive)
            cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad4
    Public Function GetAll(CodePersonneli As String, ID_MahaleKhedmat As Short) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad5
    Public Function GetAll(CodePersonneli As String, ID_Company As Byte) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@ID_Company", ID_Company)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad6
    Public Function GetAll(CodePersonneli As String, OnlyActive As Boolean, ID_Company As Byte) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@OnlyActive", OnlyActive)
            cmd.Parameters.AddWithValue("@ID_Company", ID_Company)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad7
    Public Function GetAll(CodePersonneli As String, OnlyActive As Boolean, ID_MahaleKhedmat As Short, ID_Company As Byte) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@OnlyActive", OnlyActive)
            cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat)
            cmd.Parameters.AddWithValue("@ID_Company", ID_Company)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad8
    Public Function GetAll(CodePersonneli As String, ID_MahaleKhedmat As Short, ID_Company As Byte) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat)
            cmd.Parameters.AddWithValue("@ID_Company", ID_Company)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad9
    Public Function GetAll(ID_Kargah As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad10
    Public Function GetAll(CodePersonneli As String, ID_Kargah As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad11
    Public Function GetAll(CodePersonneli As String, OnlyActive As Boolean, ID_Kargah As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@OnlyActive", OnlyActive)
            cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad12
    Public Function GetAll(CodePersonneli As String, OnlyActive As Boolean, ID_MahaleKhedmat As Short, ID_Kargah As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@OnlyActive", OnlyActive)
            cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat)
            cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad13
    Public Function GetAll(CodePersonneli As String, ID_MahaleKhedmat As Short, ID_Kargah As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat)
            cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad14
    Public Function GetAll(CodePersonneli As String, ID_Company As Byte, ID_Kargah As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@ID_Company", ID_Company)
            cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad15
    Public Function GetAll(CodePersonneli As String, OnlyActive As Boolean, ID_Company As Byte, ID_Kargah As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@OnlyActive", OnlyActive)
            cmd.Parameters.AddWithValue("@ID_Company", ID_Company)
            cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad16
    Public Function GetAll(CodePersonneli As String, OnlyActive As Boolean, ID_MahaleKhedmat As Short, ID_Company As Byte, ID_Kargah As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@OnlyActive", OnlyActive)
            cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat)
            cmd.Parameters.AddWithValue("@ID_Company", ID_Company)
            cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'OverLoad17
    Public Function GetAll(CodePersonneli As String, ID_MahaleKhedmat As Short, ID_Company As Byte, ID_Kargah As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetHokms]"
            cmd.Parameters.AddWithValue("@CodePersonneli", CodePersonneli)
            cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat)
            cmd.Parameters.AddWithValue("@ID_Company", ID_Company)
            cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah)
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetEndHokm(ID_Person As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[Pr].[UspGetEndHokm]"
            cmd.Parameters.AddWithValue("@ID_Person", ID_Person)
            Return DB.FillDataTable(cmd)
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
                    .AddWithValue("ID_Pr ", HokmItems.ID_Pr)
                    .AddWithValue("ID_Hokm ", IDHokmForLapse)
                    .AddWithValue("ID_Kargah", HokmItems.ID_Kargah)
                    .AddWithValue("ID_EtekhdamType", HokmItems.ID_EtekhdamType)
                    .AddWithValue("ID_VahedKhedmat", HokmItems.ID_VahedKhedmat)
                    .AddWithValue("ID_MahaleKhedmat", HokmItems.ID_MahaleKhedmat)
                    .AddWithValue("ID_MahaleKhedmatStatus", HokmItems.ID_MahaleKhedmatStatus)
                    .AddWithValue("ID_HokmType", HokmItems.ID_HokmType)
                    .AddWithValue("ID_Job", HokmItems.ID_Job)
                    .AddWithValue("ID_Shift", HokmItems.ID_Shift)
                    .AddWithValue("DateEstekhdam", HokmItems.DateEstekhdam)
                    .AddWithValue("DateSodoor", HokmItems.DateSodoor)
                    .AddWithValue("DateStart", HokmItems.DateStart)
                    .AddWithValue("DateEnd", HokmItems.DateEnd)
                    .AddWithValue("BasicSalaryPerMonthRls", HokmItems.BasicSalaryPerMonthRls)
                    .AddWithValue("MabEzafeKarPerHour", HokmItems.MabEzafeKarPerHour)
                    .AddWithValue("MabKasrKarPerHour", HokmItems.MabKasrKarPerHour)
                    .AddWithValue("MabShabKariPerHour", HokmItems.MabShabKariPerHour)
                    .AddWithValue("MabTatilKariPerHour", HokmItems.MabTatilKariPerHour)
                    .AddWithValue("ZaribEzafeKarPerHour", HokmItems.ZaribEzafeKarPerHour)
                    .AddWithValue("ZaribKasrKarPerHour", HokmItems.ZaribKasrKarPerHour)
                    .AddWithValue("ZaribShabKariPerHour", HokmItems.ZaribShabKariPerHour)
                    .AddWithValue("ZaribTatilKariPerHour", HokmItems.ZaribTatilKariPerHour)
                    .AddWithValue("MabOladRls", HokmItems.MabOladRls)
                    .AddWithValue("MabMaskan", HokmItems.MabMaskan)
                    .AddWithValue("MabBoneKargari", HokmItems.MabBoneKargari)
                    .AddWithValue("ID_ContractType", HokmItems.ID_ContractType)
                    .AddWithValue("ID_InsuranceType", HokmItems.ID_InsuranceType)
                    .AddWithValue("PayeSanavat", HokmItems.PayeSanavat)
                    .AddWithValue("Avamel", HokmItems.Avamel)
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
            Try
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
                Return DB.FillDataTable(cmd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public ReadOnly Property DefaultValues As DefaultVlues
            Get
                Try
                    Dim SalMali As Integer = CInt(Common.SalMali.Value)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "[Pr].[UspGetListOfAvamelDefault]"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Year", SalMali)
                    Dim Dt_Tmp As New DataTable
                    Dt_Tmp = DB.FillDataTable(cmd)
                    If Dt_Tmp.Rows.Count <= 0 Then
                        Return Nothing
                    End If
                    Dim ReturnValue As New DefaultVlues
                    With ReturnValue
                        .BasicSalaryPerMonthRls = Dt_Tmp.Rows(0).Item("BasicSalaryPerMonthRls")
                        .BasicSalaryPerDayRls = Math.Ceiling(Dt_Tmp.Rows(0).Item("BasicSalaryPerMonthRls") / 30)
                        .BasicSalaryPerHourRls = Dt_Tmp.Rows(0).Item("BasicSalaryPerMonthRls") / 220
                        .BonKargari = Dt_Tmp.Rows(0).Item("BonKargari")
                        .HaghMaskan = Dt_Tmp.Rows(0).Item("HaghMaskan")
                        .MaximumChild = Dt_Tmp.Rows(0).Item("MaximumChild")
                        .ZaribEzafeKar = Dt_Tmp.Rows(0).Item("ZaribEzafeKar")
                        .ZaribKasreKar = Dt_Tmp.Rows(0).Item("ZaribKasreKar")
                    End With
                    Return ReturnValue
                Catch ex As Exception
                    Throw ex
                End Try
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
        Public Class DefaultVlues
            Public BasicSalaryPerMonthRls As Long
            Public BasicSalaryPerDayRls As Long
            Public BasicSalaryPerHourRls As Long
            Public ZaribEzafeKar As Decimal
            Public ZaribKasreKar As Decimal
            Public MaximumChild As Integer
            Public BonKargari As Long
            Public HaghMaskan As Long
        End Class
    End Class
End Class
