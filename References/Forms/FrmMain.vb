Imports Telerik.WinControls.UI.Localization
Imports System.Data.SqlClient
Imports System.Net
Public Class FrmMain
    Dim FormIsLoad As Boolean = False
    Public Sub New(Connection1 As SqlClient.SqlConnection, Connection2 As SqlClient.SqlConnection, UserName As String)
        Try
            Dim AppName As String = "; Application Name = "
            AppName &= " PcName:" & My.Computer.Name
            'AppName &= " IP:" & Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList(1).ToString ' System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0).ToString
            AppName &= " IP:" & System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0).ToString()
            AppName &= " UserName:" & UserName
            Connection1 = New SqlConnection(Connection1.ConnectionString & "; Application Name = " & AppName)
            Db = New ClsDataAccessLayer(Connection1, Connection2)
            ActiveUser = New ClsUser(UserName.Trim)
            ' This call is required by the designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
        Catch ex As Exception
            Dialog.ShowErorr("ساخت فرم اصلی برنامه  با مشکل مواجه شد", ex.Message)
        End Try
    End Sub
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            RadGridLocalizationProvider.CurrentProvider = New ClsPersianRadGridLocalization
            FillCmbSalMali()
        Catch ex As Exception
            Dialog.ShowErorr("بارگذاری فرم اصلی با مشکل مواجه شد", ex.Message)
        End Try
    End Sub
    Private Sub FillCmbSalMali()
        Dim Base As New ClsPersonBase
        With Me.CmbSalMali.ComboBoxElement
            .DisplayMember = "Year"
            .ValueMember = "Year"
            .DataSource = Base.GetAllSalMali
        End With
    End Sub
    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SetMyProperties()
        FormIsLoad = True
    End Sub
    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If System.Diagnostics.Debugger.IsAttached = False AndAlso Dialog.ShowQuestion("آیا برای خروج مطمئن هستید ؟؟؟") = False Then
            e.Cancel = True
        End If
    End Sub
    Private Sub SetMyProperties()
        Try
            Me.LblUserName.Text = "نام کاربری : " & ActiveUser.User_Name.Trim
            Me.LblUserName.ForeColor = Color.Blue
            If Not (ActiveUser.Name = Nothing And ActiveUser.Famil = Nothing) Then
                Me.LblthName.Text = "نام طرف حساب : " & ActiveUser.Name & " " & ActiveUser.Famil
            Else
                Me.LblthName.Text = "کاربر جاری در سیستم طرف حساب ها ثبت نشده است"
                Me.LblthName.ForeColor = Color.Red
            End If
            Me.ChkIsAdmin.Checked = ActiveUser.ISAdmin
            Me.RadMenuItemVerReferences.Text = "References: " & References.Inf.Version
            Dim InfUc As New UserControls.ClsInformation
            Me.RadMenuItemVerUc.Text = "UsecControls: " & InfUc.Version
        Catch ex As Exception
            Dialog.ShowErorr("تنظیمات اولیه فرم اصلی برنامه با مشکل مواجه شد", ex.Message)
        End Try

    End Sub
    Private Sub MnuImportFromTextFile_Click(sender As Object, e As EventArgs) Handles MnuImportFromTextFile.Click
        Dim childForm As New FrmPersonnelImportWork
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub MnuReadFromMachine_Click(sender As Object, e As EventArgs) Handles MnuReadFromMachine.Click
        Dim childForm As New FrmPersonnelImportWorkFromDevice
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub MnuImportManual_Click(sender As Object, e As EventArgs) Handles MnuImportManual.Click
        Dim childForm As New FrmAddWork
        'childForm.MdiParent = Me
        childForm.ShowDialog()
        ' Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub MnuViewWorkPerDay_Click(sender As Object, e As EventArgs) Handles MnuViewWorkPerDay.Click
        Dim childForm As New FrmViewWorkPerDay
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub MnuViewWorkPerMonth_Click(sender As Object, e As EventArgs) Handles MnuViewWorkPerMonth.Click

    End Sub
    Private Sub MnuViewDefectiveWork_Click(sender As Object, e As EventArgs) Handles MnuViewDefectiveWork.Click
        Dim childForm As New FrmViewDefectiveWorks
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub CmbSalMAli_ComboBoxElement_SelectedValueChanged(sender As Object, e As Telerik.WinControls.UI.Data.ValueChangedEventArgs) Handles CmbSalMali.ComboBoxElement.SelectedValueChanged
        SalMali = CmbSalMali.ComboBoxElement.SelectedValue
        Me.BtnSalMali.Text = "سال مالی " & SalMali
        If FormIsLoad Then
            Dim msg As String = "سال مالی سیستم با موفقیت تغییر کرد"
            msg &= vbCrLf & "برای صحت عملکرد برنامه تمامی فرمها را ببندید و مجدد باز کنید"
            Dialog.ShowOK(msg)
        End If
    End Sub
    Private Sub BtnAppName_Click(sender As Object, e As EventArgs) Handles BtnAppName.Click
        '        If System.Diagnostics.Debugger.IsAttached Then
        If ActiveUser.ISAdmin Then
            Dim f As New FrmDllToDataBase
            f.ShowDialog()
        End If
    End Sub
    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        Dim childForm As New FrmViewTarafHEsab
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnAddTh_Click(sender As Object, e As EventArgs) Handles BtnAddTh.Click
        Dim childForm As New FrmAddAndEditTarafHesab
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnAddThProperty_Click(sender As Object, e As EventArgs) Handles BtnAddThProperty.Click
        Dim childForm As New FrmAddThProperty
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnEditThProperty_Click(sender As Object, e As EventArgs) Handles BtnEditThProperty.Click
        Dim childForm As New FrmEditThProperty
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnKargah_Click(sender As Object, e As EventArgs) Handles BtnKargah.Click
        Dim childForm As New FrmKargah
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnVaheds_Click(sender As Object, e As EventArgs) Handles BtnVaheds.Click
        Dim childForm As New FrmVahedKhedmat
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnEstekhdamType_Click(sender As Object, e As EventArgs) Handles BtnEstekhdamType.Click
        Dim childForm As New FrmEstekhdamType
        'childForm.MdiParent = Me
        childForm.ShowDialog()
        ' Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnViewUsers_Click(sender As Object, e As EventArgs) Handles BtnViewUsers.Click
        Dim childForm As New FrmUsers
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnChangePass_Click(sender As Object, e As EventArgs) Handles BtnChangePass.Click
        Dim childForm As New FrmModifyUser
        childForm.ShowDialog()
    End Sub

    Private Sub BtnAddKarmand_Click(sender As Object, e As EventArgs) Handles BtnAddKarmand.Click
        Dim childForm As New FrmKarmand
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnViewKarmand_Click(sender As Object, e As EventArgs) Handles BtnViewKarmand.Click
        Dim childForm As New FrmViewKarmand
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnEditPersonProperty_Click(sender As Object, e As EventArgs) Handles BtnEditPersonProperty.Click
        Dim childForm As New FrmEditThProperty
        childForm.Mode = FrmEditThProperty.PropertyType.Personely
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnAddPersonProperty_Click(sender As Object, e As EventArgs) Handles BtnAddPersonProperty.Click
        Dim childForm As New FrmAddThProperty
        childForm.Mode = FrmEditThProperty.PropertyType.Personely
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnDefault_Click(sender As Object, e As EventArgs) Handles BtnDefault.Click
        Dim childForm As New FrmDefaultHokmRls
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub RadButtonElement16_Click(sender As Object, e As EventArgs) Handles RadButtonElement16.Click
        Dim childForm As New FrmCompany
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnParametrs_Click(sender As Object, e As EventArgs) Handles BtnParametrs.Click
        Dim childForm As New FrmPrParametrs
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnWeek_Click(sender As Object, e As EventArgs) Handles BtnWeek.Click
        Dim childForm As New FrmWeek
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnAddHoliday_Click(sender As Object, e As EventArgs) Handles BtnAddHoliday.Click
        Dim childForm As New FrmHoliday
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnNewHokm_Click(sender As Object, e As EventArgs) Handles BtnNewHokm.Click
        Dim childForm As New FrmHokm
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnManageHokm_Click(sender As Object, e As EventArgs) Handles BtnManageHokm.Click
        Dim childForm As New FrmViewHokm
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnAvameleHokm_Click(sender As Object, e As EventArgs) Handles BtnAvameleHokm.Click
        Dim childForm As New FrmAvamelHokmi
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
End Class
