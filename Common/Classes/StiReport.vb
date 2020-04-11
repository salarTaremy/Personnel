Imports System.Reflection
Imports Stimulsoft.Report.Dictionary
Public Class StiReport
    Dim Ds_Report As New DataSet("لیست جداول")
    Dim rep As New Stimulsoft.Report.StiReport
    Dim Dic As New StiDictionary
    Dim IsAdmin As Boolean = False

    Public Sub New()

    End Sub
    Public Sub New(IsAdminUser As Boolean)
        Me.IsAdmin = IsAdminUser
    End Sub

    Public Sub Show()
        Try
            If Ds_Report.Tables.Count = 0 Then
                Exit Sub
            End If
            AddPublicVariable()
            Dim RefrenceFunction As New Diagnostics.StackFrame(1)
            Dim FormName As MethodBase = RefrenceFunction.GetMethod
            Dim FrmRep As New FrmSelectREport
            FrmRep.IsAdminUser = Me.IsAdmin
            FrmRep.FormName = FormName.DeclaringType.Name
            FrmRep.DsRep = Ds_Report
            FrmRep.Dictionary = Dic
            FrmRep.Report = rep
            FrmRep.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub ShowWithUnvisible(ParamArray UniqueId_To_Unvisible() As Long)
        Try
            Dim Str As String = Nothing
            For i As Integer = 0 To UniqueId_To_Unvisible.Length - 1
                If Str = Nothing Then
                    Str = "'" & UniqueId_To_Unvisible(i).ToString & "'"
                Else
                    Str &= ",'" & UniqueId_To_Unvisible(i).ToString & "'"
                End If
            Next
            If Ds_Report.Tables.Count = 0 Then
                Exit Sub
            End If
            AddPublicVariable()
            Dim RefrenceFunction As New Diagnostics.StackFrame(1)
            Dim FormName As MethodBase = RefrenceFunction.GetMethod
            Dim FrmRep As New FrmSelectREport(Str, " Not in ")
            FrmRep.FormName = FormName.DeclaringType.Name
            FrmRep.DsRep = Ds_Report
            FrmRep.Dictionary = Dic
            FrmRep.Report = rep
            FrmRep.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub ShowWithOnlyvisible(ParamArray UniqueId_Only_visible() As Long)
        Try
            Dim Str As String = Nothing
            For i As Integer = 0 To UniqueId_Only_visible.Length - 1
                If Str = Nothing Then
                    Str = "'" & UniqueId_Only_visible(i).ToString & "'"
                Else
                    Str &= ",'" & UniqueId_Only_visible(i).ToString & "'"
                End If
            Next
            If Ds_Report.Tables.Count = 0 Then
                Exit Sub
            End If
            AddPublicVariable()
            Dim RefrenceFunction As New Diagnostics.StackFrame(1)
            Dim FormName As MethodBase = RefrenceFunction.GetMethod
            Dim FrmRep As New FrmSelectREport(Str, " in ")
            FrmRep.FormName = FormName.DeclaringType.Name
            FrmRep.DsRep = Ds_Report
            FrmRep.Dictionary = Dic
            FrmRep.Report = rep
            FrmRep.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub AddDatasource(Obj As Object, Optional TableName As String = Nothing)
        Try
            If Obj Is Nothing Then
                Exit Sub
            End If
            If TableName <> Nothing Then
                Obj.TableName = TableName
            Else
                If TypeOf (Obj) Is DataTable Then
                    Obj.TableName = "جدول_" & CStr(Ds_Report.Tables.Count)
                End If
            End If
            If TypeOf (Obj) Is DataTable Then
                If Obj.Rows.Count = 0 Then
                    Exit Sub
                End If
            End If

            Ds_Report.Tables.Add(Obj.Copy)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub AddGridView(grd As Object, Optional GridName As String = Nothing)
        Try
            Dim Dt_tmp As New DataTable
            Dim dr_Tmp As DataRow
            For i As Integer = 0 To grd.Columns.Count - 1
                Dt_tmp.Columns.Add(grd.Columns(i).Name)
            Next
            For i As Integer = 0 To grd.RowCount - 1
                dr_Tmp = Dt_tmp.NewRow
                For j As Integer = 0 To grd.Columns.Count - 1
                    dr_Tmp.Item(j) = grd.Rows(i).Cells(j).Value
                Next
                Dt_tmp.Rows.Add(dr_Tmp)
            Next
            If GridName <> Nothing Then
                Dt_tmp.TableName = GridName
            Else
                Dt_tmp.TableName = "گرید_" & CStr(Ds_Report.Tables.Count)
            End If
            Ds_Report.Tables.Add(Dt_tmp.Copy)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub AddVariable(VariableName As String, Optional Value As Object = Nothing, Optional Caption As String = Nothing)
        Try
            If Caption = Nothing Then
                Caption = VariableName
            End If
            Dim StiVariable As New Stimulsoft.Report.Dictionary.StiVariable
            StiVariable.Category = "متغیر های محلی"
            StiVariable.Name = VariableName
            StiVariable.Alias = Caption
            StiVariable.Value = Value
            Dic.Variables.Add(StiVariable)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub AddPublicVariable()
        Try
            Dim StiVariable As Stimulsoft.Report.Dictionary.StiVariable
            Dim DateTime As New Common.ClsDateTime
            '════════════════════════════════════════
            StiVariable = New Stimulsoft.Report.Dictionary.StiVariable
            StiVariable.Category = "متغیر های عمومی"
            StiVariable.Name = "ServerDate"
            StiVariable.Alias = "تاریخ سرور"
            StiVariable.Value = DateTime.Pr_DateDisplay
            Dic.Variables.Add(StiVariable)
            '════════════════════════════════════════
            StiVariable = New Stimulsoft.Report.Dictionary.StiVariable
            StiVariable.Category = "متغیر های عمومی"
            StiVariable.Name = "ServerTime"
            StiVariable.Alias = "ساعت سرور "
            StiVariable.Value = DateTime.Time
            Dic.Variables.Add(StiVariable)
            '════════════════════════════════════════
            'StiVariable = New Stimulsoft.Report.Dictionary.StiVariable
            'StiVariable.Category = "متغیر های عمومی"
            'StiVariable.Name = "IP"
            'StiVariable.Alias = "IP سیستم"
            'StiVariable.Value = strIPAddress
            'Dic.Variables.Add(StiVariable)
            ''════════════════════════════════════════
            'StiVariable = New Stimulsoft.Report.Dictionary.StiVariable
            'StiVariable.Category = "متغیر های عمومی"
            'StiVariable.Name = "IP_Server"
            'StiVariable.Alias = "IP سرور"
            'StiVariable.Value = IP_KOL
            'Dic.Variables.Add(StiVariable)
            ''════════════════════════════════════════
            'StiVariable = New Stimulsoft.Report.Dictionary.StiVariable
            'StiVariable.Category = "متغیر های عمومی"
            'StiVariable.Name = "DataBaseName"
            'StiVariable.Alias = "نام پایگاه داده"
            'StiVariable.Value = DB_NAME
            'Dic.Variables.Add(StiVariable)
            ''════════════════════════════════════════
            'StiVariable = New Stimulsoft.Report.Dictionary.StiVariable
            'StiVariable.Category = "متغیر های عمومی"
            'StiVariable.Name = "DateMiladi"
            'StiVariable.Alias = "تاریخ میلادی"
            'StiVariable.Value = DateMiladi
            'Dic.Variables.Add(StiVariable)
            ''════════════════════════════════════════
            'StiVariable = New Stimulsoft.Report.Dictionary.StiVariable
            'StiVariable.Category = "متغیر های عمومی"
            'StiVariable.Name = "DateShamsi"
            'StiVariable.Alias = "تاریخ شمسی"
            'StiVariable.Value = DateShamsi
            'Dic.Variables.Add(StiVariable)
            ''════════════════════════════════════════
            'StiVariable = New Stimulsoft.Report.Dictionary.StiVariable
            'StiVariable.Category = "متغیر های عمومی"
            'StiVariable.Name = "ActiveUser"
            'StiVariable.Alias = "کاربر جاری "
            'StiVariable.Value = activeuser & "\" & Name_Computer
            'Dic.Variables.Add(StiVariable)
            ''════════════════════════════════════════
            'StiVariable = New Stimulsoft.Report.Dictionary.StiVariable
            'StiVariable.Category = "متغیر های عمومی"
            'StiVariable.Name = "PC_Name"
            'StiVariable.Alias = "کامپیوتر جاری "
            'StiVariable.Value = Name_Computer
            'Dic.Variables.Add(StiVariable)
            ''════════════════════════════════════════
            'StiVariable = New Stimulsoft.Report.Dictionary.StiVariable
            'StiVariable.Category = "متغیر های عمومی"
            'StiVariable.Name = "Year"
            'StiVariable.Alias = "سال"
            'StiVariable.Value = _Year
            'Dic.Variables.Add(StiVariable)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



End Class
