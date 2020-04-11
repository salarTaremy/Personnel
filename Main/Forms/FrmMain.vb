Imports Telerik.WinControls.UI.Localization
Imports System.Data.SqlClient
Imports System.Net
Imports Personnely
Imports Salary.Forms

Public Class FrmMain
    Dim FormIsLoad As Boolean = False
    Dim SalMali As Integer
    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick

    End Sub
    Public Sub New(UserName As String)
        Try
            Db = New DAL.ClsDataAccessLayer()
            ActiveUser = New Permission.ClsUser(UserName.Trim)
            InitializeComponent()
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
        Dim SalMali As New Common.SalMali
        With Me.CmbSalMali.ComboBoxElement
            .DisplayMember = "Name"
            .ValueMember = "ID"
            .DataSource = SalMali.GetSalMali()
        End With
    End Sub
    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SetMyProperties()
        CmbSalMali.ComboBoxElement.SelectedIndex = (Me.CmbSalMali.Items.Count - 1)
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

            Dim infCommon As New Common.ClsInformation
            Me.Lbl1.Text = "Common: " & infCommon.Version

            Dim infDal As New DAL.ClsInformation
            Me.Lbl2.Text = "Dal: " & infDal.Version

            'Dim InfMain As New Main.ClsInformation
            Me.Lbl3.Text = "Main: " & Main.Inf.Version

            Dim InfPermission As New Permission.ClsInformation
            Me.Lbl4.Text = "Permission: " & InfPermission.Version

            Dim InfPersonneli As New Personnely.ClsInformation
            Me.Lbl5.Text = "Personnely: " & InfPersonneli.Version

            Dim InfSalary As New Salary.ClsInformation
            Me.Lbl6.Text = "Salary: " & InfSalary.Version


            Dim InfTh As New TarafHesab.ClsInformation
            Me.Lbl7.Text = "TarafHesab: " & InfTh.Version

            Dim InfUc As New UserControls.ClsInformation
            Me.Lbl8.Text = "UsecControls: " & InfUc.Version
        Catch ex As Exception
            Dialog.ShowErorr("تنظیمات اولیه فرم اصلی برنامه با مشکل مواجه شد", ex.Message)
        End Try

    End Sub
    Private Sub MnuImportFromTextFile_Click(sender As Object, e As EventArgs) Handles MnuImportFromTextFile.Click
        Dim childForm As New Personnely.FrmPersonnelImportWork
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub MnuReadFromMachine_Click(sender As Object, e As EventArgs) Handles MnuReadFromMachine.Click
        Dim childForm As New Personnely.FrmPersonnelImportWorkFromDevice
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub MnuImportManual_Click(sender As Object, e As EventArgs) Handles MnuImportManual.Click
        Dim childForm As New Personnely.FrmAddWork
        'childForm.MdiParent = Me
        childForm.ShowDialog()
        ' Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub MnuViewWorkPerDay_Click(sender As Object, e As EventArgs) Handles MnuViewWorkPerDayWithDetail.Click
        Dim childForm As New FrmViewWorkPerDayWithDetail
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub MnuViewDefectiveWork_Click(sender As Object, e As EventArgs) Handles MnuViewDefectiveWork.Click
        Dim childForm As New FrmViewDefectiveWorks
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub MnuWorkPerDay_Click(sender As Object, e As EventArgs) Handles MnuWorkPerDay.Click
        Dim childForm As New Salary.Forms.FrmWorkPerDay
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub MnuWorkPerDayWithDetail_Click(sender As Object, e As EventArgs) Handles MnuWorkPerDayWithDetail.Click
        Dim childForm As New Salary.Forms.FrmWorkPerDayWithDetail
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub MnuWorkPerMonth_Click(sender As Object, e As EventArgs) Handles MnuWorkPerMonth.Click
        Dim childForm As New Salary.Forms.FrmWorkPerMonth
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub CmbSalMAli_ComboBoxElement_SelectedValueChanged(sender As Object, e As Telerik.WinControls.UI.Data.ValueChangedEventArgs) Handles CmbSalMali.ComboBoxElement.SelectedValueChanged
        SalMali = CmbSalMali.ComboBoxElement.SelectedValue
        Dim Reg As New Common.ClsRegistery
        Reg.SetValue("SalMali", SalMali.ToString.Trim)
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
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim f As New FrmSaveFileToDb
                f.ShowDialog()
            Else
                Dim f As New FrmDllToDataBase
                f.ShowDialog()
            End If
        End If
    End Sub
    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        Dim childForm As New TarafHesab.FrmViewTarafHEsab
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnAddTh_Click(sender As Object, e As EventArgs) Handles BtnAddTh.Click
        Dim childForm As New TarafHesab.FrmAddAndEditTarafHesab
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnAddThProperty_Click(sender As Object, e As EventArgs) Handles BtnAddThProperty.Click
        Dim childForm As New FrmAddThProperty
        childForm.Mode = FrmEditThProperty.PropertyType.Th_Hesab
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
        Dim childForm As New Personnely.FrmKarmand
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnViewKarmand_Click(sender As Object, e As EventArgs) Handles BtnViewKarmand.Click
        Dim childForm As New Personnely.FrmViewKarmand
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
    Private Sub RadButtonElement16_Click(sender As Object, e As EventArgs) Handles RadButtonElement16.Click
        Dim childForm As New FrmCompany
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnParametrs_Click(sender As Object, e As EventArgs) Handles BtnParametrs.Click
        Dim childForm As New Personnely.FrmPrParametrs
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnWeek_Click(sender As Object, e As EventArgs) Handles BtnWeek.Click
        Dim childForm As New Personnely.FrmWeek
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnAddHoliday_Click(sender As Object, e As EventArgs) Handles BtnAddHoliday.Click
        Dim childForm As New FrmHoliday(SalMali)
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnNewHokm_Click(sender As Object, e As EventArgs) Handles BtnNewHokm.Click
        Dim childForm As New Personnely.FrmHokm
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnManageHokm_Click(sender As Object, e As EventArgs) Handles BtnManageHokm.Click
        Dim childForm As New Personnely.FrmViewHokm
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnAvameleHokm_Click(sender As Object, e As EventArgs) Handles BtnAvameleHokm.Click
        Dim childForm As New Personnely.FrmAvamelHokmi
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnDefaultHokm_Click(sender As Object, e As EventArgs) Handles BtnDefaultHokm.Click
        Dim childForm As New Personnely.FrmDefaultHokmRls
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnMissionAndLeavePerHour_Click(sender As Object, e As EventArgs) Handles BtnMissionPerHour.Click
        Dim childForm As New Salary.Forms.FrmViewHourlyMission
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnLeavePerHour_Click(sender As Object, e As EventArgs) Handles BtnLeavePerHour.Click
        Dim childForm As New Salary.Forms.FrmViewHourlyLeave
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnMissionType_Click(sender As Object, e As EventArgs) Handles BtnMissionType.Click
        Dim childForm As New Salary.Forms.FrmMissionType
        'childForm.MdiParent = Me
        childForm.ShowDialog()
        'Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnLeaveType_Click(sender As Object, e As EventArgs) Handles BtnLeaveType.Click
        Dim childForm As New Salary.Forms.FrmLeaveType
        'childForm.MdiParent = Me
        childForm.ShowDialog()
        'Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnMissionPerDay_Click(sender As Object, e As EventArgs) Handles BtnMissionPerDay.Click
        Dim childForm As New Salary.Forms.FrmViewDailyMission
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnLeavePerDay_Click(sender As Object, e As EventArgs) Handles BtnLeavePerDay.Click
        Dim childForm As New Salary.Forms.FrmViewDailyLeave
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnKargah_Click_1(sender As Object, e As EventArgs) Handles BtnKargah.Click
        Dim childForm As New Personnely.FrmKargah
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub





    Private Sub BtnVahed_Click(sender As Object, e As EventArgs) Handles BtnVahed.Click
        Dim childForm As New Personnely.FrmVahedKhedmat
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnEstekhdam_Click(sender As Object, e As EventArgs) Handles BtnEstekhdam.Click
        Dim childForm As New Personnely.FrmEstekhdamType
        'childForm.MdiParent = Me
        childForm.ShowDialog()
        ' Me.RadDock.ActivateMdiChild(childForm)
    End Sub








    Private Sub BtnBlackList_Click(sender As Object, e As EventArgs) Handles BtnBlackList.Click
        Dim childForm As New Salary.Forms.FrmBlackListPerson
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub RadButtonElement1_Click(sender As Object, e As EventArgs) Handles RadButtonElement1.Click
        Dim childForm As New FrmSalMali
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnSabtKarkard_Click(sender As Object, e As EventArgs) Handles BtnSabtKarkard.Click
        Dim childForm As New Salary.Forms.FrmEntryWork
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnSyncMission_Click(sender As Object, e As EventArgs) Handles BtnSyncMission.Click
        Dim childForm As New Salary.Forms.FrmSyncMission
        'childForm.MdiParent = Me
        childForm.ShowDialog()
        'Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnSyncLeave_Click(sender As Object, e As EventArgs) Handles BtnSyncLeave.Click
        Dim childForm As New Salary.Forms.FrmSyncLeave
        'childForm.MdiParent = Me
        childForm.ShowDialog()
        'Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnManagePayroll_Click(sender As Object, e As EventArgs) Handles BtnManagePayroll.Click
        Dim childForm As New Salary.Forms.FrmManagePayroll
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnMaliat_Click(sender As Object, e As EventArgs) Handles BtnMaliat.Click
        Dim childForm As New Salary.Forms.FrmTax
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnListBime_Click(sender As Object, e As EventArgs) Handles BtnListBime.Click
        Dim childForm As New Salary.Forms.FrmInsuranceList
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnAddPayroll_Click(sender As Object, e As EventArgs) Handles BtnAddPayroll.Click
        Dim childForm As New Salary.Forms.FrmWorkPerMonth
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnListOfSales_Click(sender As Object, e As EventArgs) Handles BtnListOfSales.Click
        Dim childForm As New Salary.Forms.FrmMonthlyList
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnVamJadid_Click(sender As Object, e As EventArgs) Handles BtnVamJadid.Click
        Dim childForm As New Salary.Forms.FrmNewLoan
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnFormul_Click(sender As Object, e As EventArgs) Handles BtnFormul.Click
        Dim childForm As New Salary.Forms.FrmAdvance
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnAdvanceGroup_Click(sender As Object, e As EventArgs) Handles BtnAdvanceGroup.Click
        Dim childForm As New Salary.Forms.FrmPayAdvanceGroup
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnManageLoan_Click(sender As Object, e As EventArgs) Handles BtnManageLoan.Click
        Dim childForm As New Salary.Forms.FrmManageLoan
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnManageAvance_Click(sender As Object, e As EventArgs) Handles BtnManageAvance.Click
        Dim childForm As New Salary.Forms.FrmManageAdvance
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnAdvance_Click(sender As Object, e As EventArgs) Handles BtnAdvance.Click
        Dim childForm As New Salary.Forms.FrmPayAdvance
        'childForm.MdiParent = Me
        childForm.ShowDialog()
        'Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnBlackListAdvance_Click(sender As Object, e As EventArgs) Handles BtnBlackListAdvance.Click
        Dim childForm As New Salary.Forms.FrmAdvanceBlacklist
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
    Private Sub BtnMonthOfPay_Click(sender As Object, e As EventArgs) Handles BtnMonthOfPay.Click
        Dim childForm As New Salary.Forms.FrmMonthOfSalary
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnListMaliat_Click(sender As Object, e As EventArgs) Handles BtnListMaliat.Click
        Dim childForm As New Salary.Forms.FrmTaxList
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnFormul2_Click(sender As Object, e As EventArgs) Handles BtnPayFormool.Click
        Dim childForm As New Salary.Forms.FrmFormulEydiSanavat
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnPayEydi_Click(sender As Object, e As EventArgs) Handles BtnPayEydi.Click
        Dim childForm As New Salary.Forms.FrmEydiSanavat(1)
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnPayOther_Click(sender As Object, e As EventArgs) Handles BtnPayOther.Click
        Dim childForm As New Salary.Forms.FrmPayOther
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnBuyPersonel_Click(sender As Object, e As EventArgs) Handles BtnBuyPersonel.Click
        Dim childForm As New Salary.Forms.FrmPersonPay
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnPaySanavat_Click(sender As Object, e As EventArgs) Handles BtnManageEydi.Click
        Dim childForm As New Salary.Forms.FrmManageEydiSanavat(1)
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub RadButtonElement19_Click(sender As Object, e As EventArgs) Handles BtnPaySanavat.Click
        Dim childForm As New Salary.Forms.FrmEydiSanavat(2)
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnManageSanavat_Click(sender As Object, e As EventArgs) Handles BtnManageSanavat.Click
        Dim childForm As New Salary.Forms.FrmManageEydiSanavat(2)
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnBazNeshastegan_Click(sender As Object, e As EventArgs) Handles BtnBazNeshastegan.Click
        Dim childForm As New Salary.Forms.FrmOldPerson()
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub

    Private Sub BtnTasviye_Click(sender As Object, e As EventArgs) Handles BtnTasviye.Click
        Dim childForm As New FrmManageTasviye
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)

    End Sub

    Private Sub BtnResidEydiSanavat_Click(sender As Object, e As EventArgs) Handles BtnResidEydiSanavat.Click
        Dim childForm As New FrmResidEydiSanavat
        childForm.MdiParent = Me
        childForm.Show()
        Me.RadDock.ActivateMdiChild(childForm)
    End Sub
End Class
