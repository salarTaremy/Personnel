Imports System.Reflection
Imports System.Text
Public Class FrmSelectREport
    Public FormName As String = Nothing
    Public DsRep As New DataSet
    Public Report As New Stimulsoft.Report.StiReport
    Public Dictionary As New Stimulsoft.Report.Dictionary.StiDictionary
    Dim cmd As New SqlClient.SqlCommand
    Dim DtReportFiles As New DataTable
    Dim DrReportFiles As DataRow
    Dim _s As String = Nothing
    Dim _Operator As String = Nothing
    Dim ConvertExcel As Boolean
    Private Sub Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmd.CommandType = CommandType.Text
            FillCmb()
            UserCheck()
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Sub
    Private _IsAdminUser As Boolean
    Public Property IsAdminUser() As Boolean
        Get
            Return _IsAdminUser
        End Get
        Set(ByVal value As Boolean)
            _IsAdminUser = value
        End Set
    End Property
    Private Sub UserCheck()
        Try
            If Diagnostics.Debugger.IsAttached Or Me.IsAdminUser Then
                Me.BtnAdd.Enabled = True
                Me.BtnEdit.Enabled = True
                Me.BtnDell.Enabled = True
                Me.BtnLock.Enabled = True
                Me.BtnCopy.Enabled = True
            End If
            Me.BtnEdit.Enabled = True
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Sub
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Add()
            FillCmb()
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Sub
    Private Sub FillCmb()
        Try
            cmd.CommandText = "SELECT [Counter], ReportName ,Password  FROM [PersonnelSystemDB]..ReportFiles  wHERE FormName = @FormName"
            If Me._s <> Nothing And Me._Operator <> Nothing Then
                cmd.CommandText &= vbCrLf & "AND Unique_ID  " & Me._Operator & "  (  " & _s & "  )"
            End If
            cmd.CommandText &= vbCrLf & "  Order By Counter"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@FormName", FormName)
            '        DtReportFiles = m_cls_database.fill_dataset_param(cmd).Tables(0)
            DtReportFiles = DB.FillDataTable(cmd)
            Grd.DataSource = DtReportFiles
            Me.CmbRep.Text = ""
            Me.CmbRep.DataSource = DtReportFiles
            Me.CmbRep.DisplayMember = "ReportName"
            Me.CmbRep.ValueMember = "Counter"
            Me.CmbRep.ListElement.Font = New System.Drawing.Font("tahoma", 8.25)
            If Me.CmbRep.Items.Count > 0 Then
                Me.CmbRep.SelectedIndex = Me.CmbRep.Items.Count - 1
            End If
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Sub
    Private Function GetReport(Counter As String) As Stimulsoft.Report.StiReport
        Try
            cmd.CommandText = " select Value  from PersonnelSystemDB..ReportFiles where counter = @Counter"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Counter", Counter.Trim)

            Dim ReportByte As Byte() = DirectCast(DB.ExecuteScalar(cmd, True), Byte())
            Dim Rep As New Stimulsoft.Report.StiReport
            Rep.Load(ReportByte)
            Rep.RegData(DsRep)
            For i As Integer = 0 To Me.Dictionary.Variables.Count - 1
                Rep.Dictionary.Variables.Add(Me.Dictionary.Variables(i))
            Next
            Return Rep
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Function
    Public Sub Add()
        Try
            Dim f As New FrmAddStiReport
            Dim SampleRep As Stimulsoft.Report.StiReport = Nothing
            f.ShowDialog()
            If f.RepName Is Nothing Then
                Exit Sub
            End If
            If f.COUNTER > 0 Then
                SampleRep = GetReport(f.COUNTER)
                SampleRep.DataSources.Clear()
                For i As Integer = 0 To Me.Report.Dictionary.Variables.Count - 1
                    SampleRep.Dictionary.Variables.Add(Me.Report.Dictionary.Variables(i))
                Next
            End If
            Dim CmdText As String = Nothing
            'CmdText &= "INSERT INTO [StiReport].[dbo].[ReportFiles]([ID],[Unique_ID],[FormName],[ReportName],[Value])" & vbCrLf
            'CmdText &= "select [ID]=(SELECT ISNULL(MAX(ID),0)+1 FROM StiReport.DBO.ReportFiles WHERE FormName = @FormName)" & vbCrLf
            'CmdText &= ",[Unique_ID]=(SELECT ISNULL(MAX([Unique_ID]),0)+1 FROM StiReport.DBO.ReportFiles)" & vbCrLf
            'CmdText &= ",[FormName] = @FormName,[ReportName]= @ReportName,[Value]=@Value" & vbCrLf

            CmdText &= "INSERT INTO [PersonnelSystemDB].[dbo].[ReportFiles]([ID],[Unique_ID],[FormName],[ReportName],[Value])" & vbCrLf
            CmdText &= "select [ID]=(SELECT ISNULL(MAX(ID),0)+1 FROM [PersonnelSystemDB].DBO.ReportFiles WHERE FormName = @FormName)" & vbCrLf
            CmdText &= ",[Unique_ID]=(SELECT ISNULL(MAX([Unique_ID]),0)+1 FROM [PersonnelSystemDB].DBO.ReportFiles)" & vbCrLf
            CmdText &= ",[FormName] = @FormName" & vbCrLf
            CmdText &= ",[ReportName]= @ReportName,[Value]=@Value" & vbCrLf




            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@FormName", FormName)
            cmd.Parameters.AddWithValue("@ReportName", f.RepName)
            If f.COUNTER > 0 Then
                cmd.Parameters.AddWithValue("@Value", SampleRep.SaveToByteArray)
            Else
                cmd.Parameters.AddWithValue("@Value", Report.SaveToByteArray)
            End If

            cmd.CommandText = CmdText
            If DB.ExecuteNonQuery(cmd, True) Then
                Dialog.ShowOK("عملیات با موفقیت انجام شد")
            Else
                Dialog.ShowInfo("ذخیره انجام نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Sub
    Private Sub Remove()
        If Not ExistReport() Then
            Exit Sub
        End If
        Try
            cmd.CommandText = "DELETE FROM [PersonnelSystemDB]..ReportFiles  WHERE [Counter] = @COUNTER"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Counter", Me.CmbRep.SelectedValue)
            If DB.ExecuteNonQuery(cmd) > 0 Then
                Dialog.ShowOK("گزارش با موفقیت حذف شد")

            Else
                Dialog.ShowInfo("حذف انجام نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Sub
    Private Sub BtnDell_Click(sender As Object, e As EventArgs) Handles BtnDell.Click
        If Dialog.ShowQuestion("آیا برای حذف این گزارش مطمئن هستید ؟؟؟") = True Then
            Remove()
            FillCmb()
        End If
    End Sub
    Private Function ExistReport() As Boolean
        Try
            If Me.CmbRep.SelectedValue = Nothing Then
                Dialog.ShowInfo("گزارشی  وجود ندارد")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Function
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            If Not ExistReport() Then
                Exit Sub
            End If
            Dim f As New FrmStiDesigner
            For i As Integer = 0 To f.Designer.Controls.Count - 1
                f.Designer.Controls(i).Font = New System.Drawing.Font("tahoma", 8.25)
            Next
            f.Rep = GetReport(Me.CmbRep.SelectedValue)
            f.CounterOfReport = Me.CmbRep.SelectedValue.ToString
            f.ShowDialog()
        Catch ex As Exception
            Dialog.ShowInfo(ex.Message)
        End Try
    End Sub
    Private Sub BtnView_Click(sender As Object, e As EventArgs, Optional Exp As String = Nothing) Handles BtnView.Click
        Try
            If Not ExistReport() Then
                Exit Sub
            End If
            If String.IsNullOrEmpty(Me.Grd.CurrentRow.Cells("password").Value.ToString) Then
                GetReport(Me.CmbRep.SelectedValue.ToString).Show()
            Else
                'If m_cls_tools.CheckPassword(Me.Grd.CurrentRow.Cells("password").Value.ToString, Nothing, False) Then
                GetReport(Me.CmbRep.SelectedValue.ToString).Show(True)
                '    End If
            End If

            'If Exp = "Close" Then
            '    Me.Close()
            'End If
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try

    End Sub

    Private Sub BtnLock_Click(sender As Object, e As EventArgs) Handles BtnLock.Click
        Try
            If Not ExistReport() Then
                Exit Sub
            End If
            Dim pass As String
            If BtnLock.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
                pass = InputBox("رمز عبور", "رمز عبور را برای این گزارش وارد کنید")
                If pass = Nothing Then Exit Sub
            ElseIf BtnLock.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                pass = Nothing
            End If
            If pass = Nothing Then
                cmd.Parameters.Clear()
                cmd.CommandText = "UPDATE PersonnelSystemDB..ReportFiles SET Password = NULL Where counter = @counter"
                cmd.Parameters.AddWithValue("@counter", Me.CmbRep.SelectedValue)
                Me.Grd.CurrentRow.Cells("password").Value = DBNull.Value
                If DB.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("رمز این گزارش حذف شد")
                Else
                    Dialog.ShowInfo("عملیات انجام نشد")
                End If
            Else
                cmd.Parameters.Clear()
                cmd.CommandText = "UPDATE PersonnelSystemDB..ReportFiles SET Password = @PASS  Where counter = @counter"
                cmd.Parameters.AddWithValue("@PASS", pass.Trim)
                cmd.Parameters.AddWithValue("@counter", Me.CmbRep.SelectedValue)
                Me.Grd.CurrentRow.Cells("password").Value = pass.Trim
                If DB.ExecuteNonQuery(cmd) > 0 Then
                    Dialog.ShowOK("برای این گزارش رمز گذاشته شد")
                Else
                    Dialog.ShowInfo("عملیات انجام نشد")
                End If
            End If
        Catch ex As Exception
            Dialog.ShowInfo(ex.Message)
        End Try
    End Sub
    Private Sub CmbRep_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbRep.SelectedValueChanged
        Try
            If Me.Grd.RowCount = 0 Then
                Exit Sub
            End If
            Dim IsLock As Boolean = String.IsNullOrEmpty(Me.Grd.CurrentRow.Cells("Password").Value.ToString)
            If IsLock Then
                Me.BtnLock.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
            Else
                Me.BtnLock.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End If
       Catch ex As Exception
            Dialog.ShowInfo(ex.Message)
        End Try
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        If Not ExistReport() Then
            Exit Sub
        End If
        Try
            Dim ReportName As String = InputBox("نام جدیدی برای این گزارش انتخاب کنید:", "کپی از  " & Me.CmbRep.Text)
            If ReportName = Nothing Or ReportName = "" Then
                Exit Sub
            End If
            Dim Str As String = Nothing
            Str &= "INSERT INTO  [PersonnelSystemDB]..ReportFiles (Unique_ID ,ID ,FormName ,ReportName ,Value ,[Password] )" & vbCrLf
            Str &= "SELECT  [Unique_ID]=(SELECT ISNULL(MAX(Unique_ID),0)+1 FROM [PersonnelSystemDB]..ReportFiles)" & vbCrLf
            Str &= ",[ID]=(SELECT ISNULL(MAX(ID),0)+1 FROM [PersonnelSystemDB]..ReportFiles WHERE FormName = (SELECT FormName  FROM [PersonnelSystemDB]..ReportFiles WHERE Counter =  @Counter))" & vbCrLf
            Str &= ",Rep.FormName ,@ReportName ,Rep.Value , Rep.Password  FROM [PersonnelSystemDB]..ReportFiles AS Rep WHERE Counter = @Counter " & vbCrLf
            cmd.CommandText = Str
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Counter", Me.CmbRep.SelectedValue)
            cmd.Parameters.AddWithValue("@ReportName", ReportName)
            If DB.ExecuteNonQuery(cmd) > 0 Then
                Dialog.ShowOK("یک کپی  از این گزارش با نام " & ReportName & " اضافه شد")
            Else
                Dialog.ShowInfo("عملیات انجام نشد")
            End If
            FillCmb()
        Catch ex As Exception
            Dialog.ShowInfo(ex.Message)
        End Try
    End Sub

    Private Sub FrmSelectREport_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Me.CmbRep.Items.Count = 1 And My.Computer.Keyboard.ShiftKeyDown = False Then
            BtnView_Click(Nothing, Nothing, "Close")
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(s As String, OperatorIn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._s = s
        Me._Operator = OperatorIn

    End Sub

End Class