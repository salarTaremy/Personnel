Public Class FrmHokm
    Dim Pr As New ClsPersonel
    Dim Hokm As New ClsHokm
    Dim Items As New ClsHokm.Items
    Dim Amel As New ClsHokm.Avamel
    Dim DefaultValues As New ClsHokm.Avamel.DefaultVlues
    Dim HokmID As Long = Nothing

    Public Sub New(Optional HokmID As Long = 0)
        InitializeComponent()
        Me.HokmID = HokmID
    End Sub
    Private Sub FrmHokm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillAllCmb()
        FillGrid()
        SetControlTexts()
        If Me.HokmID > 0 Then
            LoadHokm()
        End If
    End Sub
    Public Sub LoadHokm()
        Me.Text = "در حال ویرایش حکم شماره : " & HokmID
        Dim DtHokm As New DataTable
        DtHokm = Hokm.GetByID(HokmID)
        With DtHokm
            Me.TxtPrID.Value = .Rows(0).Item("ID_Pr")
            Me.CmbKargah.SelectedValue = .Rows(0).Item("ID_Kargah")
            Me.CmbEstekhdam.SelectedValue = .Rows(0).Item("ID_EtekhdamType")
            Me.CmbKhedmat.SelectedValue = .Rows(0).Item("ID_VahedKhedmat")
            Me.CmbShifts.SelectedValue = .Rows(0).Item("ID_Shift")
            Me.CmbHokm.SelectedValue = .Rows(0).Item("ID_HokmType")
            Me.CmbJob.SelectedValue = .Rows(0).Item("ID_Job")
            Me.UcDateEstekhdam.TxtInt = .Rows(0).Item("DateEstekhdam")
            Me.UcSodorHokm.TxtInt = .Rows(0).Item("DateSodoor")
            Me.UcStartDate.TxtInt = .Rows(0).Item("DateSodoor")
            Me.UcEndDate.TxtInt = .Rows(0).Item("DateEnd")
            Me.TxtPayeh.Text = .Rows(0).Item("BasicSalaryPerMonthRls")
            Me.TxtZaribEzafehKar.Value = .Rows(0).Item("MabEzafeKarPerHour") / (.Rows(0).Item("BasicSalaryPerMonthRls") / 220)
            Me.TxtZaribKasrKar.Value = .Rows(0).Item("MabKasrKarPerHour") / (.Rows(0).Item("BasicSalaryPerMonthRls") / 220)
            Me.TxtBon.Text = .Rows(0).Item("MabBoneKargari")
            Me.TxtHaghMaskan.Text = .Rows(0).Item("MabMaskan")
            Me.TxtSaghfFarzand.Value = (.Rows(0).Item("MabOladRls") / DefaultValues.BasicSalaryPerDayRls) / 3
            Me.TxtOlad.Text = .Rows(0).Item("MabOladRls")
        End With
    End Sub
    Private Sub SetControlTexts()
        DefaultValues = Amel.DefaultValues
        With DefaultValues
            Me.TxtPayeh.Text = .BasicSalaryPerMonthRls
            Me.TxtZaribEzafehKar.Value = .ZaribEzafeKar
            Me.TxtZaribKasrKar.Value = .ZaribKasreKar
            Me.TxtBon.Text = .BonKargari
            Me.TxtHaghMaskan.Text = .HaghMaskan
            Me.TxtSaghfFarzand.Value = .MaximumChild
        End With
        UcDateEstekhdam.txt = Inf.PersianYear & "/01/01"
        UcStartDate.txt = Inf.PersianYear & "/01/01"
        UcEndDate.txt = Nothing
    End Sub

    Private Sub FillGrid()
        Me.GrdAvamel.DataSource = Amel.GetListOfAvamel(True, HokmID)
        For i As Integer = 0 To Me.GrdAvamel.Columns.Count - 1
            Me.GrdAvamel.Columns(i).ReadOnly = True
        Next
        With Me.GrdAvamel
            .Columns("IsSelect").HeaderText = "√"
            .Columns("ID").IsVisible = False
            .Columns("Name").HeaderText = "شرح"
            .Columns("TypeValue").HeaderText = "نوع"
            .Columns("Value").HeaderText = "مقدار"
            .Columns("CalcValue").HeaderText = "نوع محاسبه"
            .Columns("BaseValue").HeaderText = "مبنای محاسبه"
            .Columns("Priority").IsVisible = False
            .Columns("AlowChengeDefaultValue").IsVisible = False
            .Columns("Detail").HeaderText = "توضیحات"
            .Columns("IsSelect").ReadOnly = False
            .Columns("Value").ReadOnly = False
            ''''''''''''''
            .Columns("IsSelect").Width = 15
            .Columns("ID").Width = 10
            .Columns("Name").Width = 160
            .Columns("TypeValue").Width = 80
            .Columns("Value").Width = 120
            .Columns("CalcValue").Width = 80
            .Columns("BaseValue").Width = 80
            .Columns("Priority").Width = 10
            .Columns("AlowChengeDefaultValue").Width = 10
            .Columns("Detail").Width = 160
            '.Columns("Value").FormatString = "{0:#,###,##0.0;(#,###,0.0)}"
            .Columns("Value").FormatString = "{0:#,###,##0;(#,###,0)}"
        End With
    End Sub

    Private Sub BtnBrows_Click(sender As Object, e As EventArgs) Handles BtnBrows.Click
        Me.TxtPrID.Value = Pr.SelectPersonID()
    End Sub

    Private Sub TxtPrID_ValueChanged(sender As Object, e As EventArgs) Handles TxtPrID.ValueChanged
        Pr = New ClsPersonel(TxtPrID.Value)
        If Pr.Exists Then
            Me.TxtName.Text = Pr.Name & " " & Pr.Famil
            Me.TxtChildCount.Text = Pr.ChilCount
        Else
            Me.TxtName.Text = Nothing
            Me.TxtChildCount.Text = Nothing
        End If
        If Pr.Exists Then
            Dim Th As New ClsTarafHesab(Pr.ID_TarafHesab)
            With Me.Grd_Pr
                .DataSource = Pr.GetAllProperties
                If .Columns.Contains("ID_PR") Then .Columns("ID_PR").IsVisible = False
                If .Columns.Contains("PropertyName") Then .Columns("PropertyName").HeaderText = "عنوان"
                If .Columns.Contains("Value") Then .Columns("Value").HeaderText = "شرح"
            End With
            With Me.Grd_Th
                .DataSource = Th.GetAllProperties
                If .Columns.Contains("ID_PR") Then .Columns("ID_PR").IsVisible = False
                If .Columns.Contains("PropertyName") Then .Columns("PropertyName").HeaderText = "عنوان"
                If .Columns.Contains("Value") Then .Columns("Value").HeaderText = "شرح"
            End With
        Else
            Me.Grd_Pr.DataSource = Nothing
            Me.Grd_Th.DataSource = Nothing
        End If
    End Sub
    Private Sub FillAllCmb()
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandText &= vbCrLf & "Exec [pr].[UspGetKarkah] "
            .CommandText &= vbCrLf & "Exec [pr].[UspGetEstekhdamTypes]"
            .CommandText &= vbCrLf & "Exec [pr].[UspGetVahedKhedmat]"
            .CommandText &= vbCrLf & "Exec [pr].[UspGetHokmType]"
            .CommandText &= vbCrLf & "Exec [Pr].[UspGetAllShifts]"
        End With
        Dim DsTemp As New DataSet
        DsTemp = Db.FillDataSet(cmd)
        With Me.CmbKargah
            .DataSource = DsTemp.Tables(0)
            .DisplayMember = "Name"
            .ValueMember = "ID"
        End With
        With Me.CmbEstekhdam
            .DataSource = DsTemp.Tables(1)
            .DisplayMember = "Name"
            .ValueMember = "ID"
        End With
        With Me.CmbKhedmat
            .DataSource = DsTemp.Tables(2)
            .DisplayMember = "Name"
            .ValueMember = "ID"
        End With
        With Me.CmbHokm
            .DataSource = DsTemp.Tables(3)
            .DisplayMember = "Name"
            .ValueMember = "ID"
        End With
        With Me.CmbShifts
            .DataSource = DsTemp.Tables(4)
            .DisplayMember = "Name"
            .ValueMember = "ID"
        End With
        ''''''''''''''''''''''''''''''''''''''''''''''
        If DtJobs.Rows.Count = 0 Then
            cmd.CommandText = "[pr].[UspGetJobs]"
            cmd.CommandType = CommandType.StoredProcedure
            DtJobs = Db.FillDataTable(cmd)
        End If
        With Me.CmbJob
            .DataSource = DtJobs
            .DisplayMember = "Value"
            .ValueMember = "ID"
        End With
    End Sub
    Private Function IsValidData() As Boolean
        If Not Me.Pr.Exists Then
            Dialog.ShowInfo("لطفا کارمندی را جهت صدور حکم انتخاب کنید انتخاب کنید")
            RadPageView1.SelectedPage = Me.RadPageView1.Pages(0)
            Return False
        End If
        If Me.CmbKargah.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفا  کارگاه را انتخاب کنید")
            RadPageView1.SelectedPage = Me.RadPageView1.Pages(0)
            Return False
        End If
        If Me.CmbEstekhdam.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفا نوع استخدام را انتخاب کنید")
            RadPageView1.SelectedPage = Me.RadPageView1.Pages(0)
            Return False
        End If
        If Me.CmbKhedmat.SelectedValue = 0 Then
            Dialog.ShowInfo(" لطفا محل خدمت را انتخاب کنید")
            RadPageView1.SelectedPage = Me.RadPageView1.Pages(0)
            Return False
        End If
        If Me.CmbHokm.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفا نوع حکم را انتخاب کنید")
            RadPageView1.SelectedPage = Me.RadPageView1.Pages(0)
            Return False
        End If
        If Me.CmbJob.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفا شغل سازمانی را انتخاب کنید")
            RadPageView1.SelectedPage = Me.RadPageView1.Pages(0)
            Return False
        End If
        If UcEndDate.txt = "" Or UcEndDate.txt = Nothing Then
            Dialog.ShowInfo("لطفا تاریخ اعنبار حکم را وارد کنید کنید")
            RadPageView1.SelectedPage = Me.RadPageView1.Pages(0)
            Return False
        End If
        Return True
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            If Not IsValidData() Then
                Exit Sub
            End If
            With Items
                .ID_Pr = TxtPrID.Value
                .ID_Kargah = CmbKargah.SelectedValue
                .ID_HokmType = CmbEstekhdam.SelectedValue
                .ID_VahedKhedmat = CmbKhedmat.SelectedValue
                .ID_HokmType = CmbHokm.SelectedValue
                .ID_EtekhdamType = CmbEstekhdam.SelectedValue
                .ID_Job = CmbJob.SelectedValue
                .ID_Shift = Me.CmbShifts.SelectedValue
                .DateEstekhdam = UcDateEstekhdam.TxtInt
                .DateSodoor = UcSodorHokm.TxtInt
                .DateStart = UcStartDate.TxtInt
                .DateEnd = UcEndDate.TxtInt
                .BasicSalaryPerMonthRls = TxtPayeh.Rls
                .MabEzafeKarPerHour = TxtMabEzafehKar.Rls
                .MabKasrKarPerHour = TxtMabKasrKar.Rls
                .MabOladRls = TxtOlad.Rls
                .MabBoneKargari = TxtBon.Rls
                .MabMaskan = TxtHaghMaskan.Rls
                .Avamel = GetDtAvamel()
            End With
            If Hokm.AddNew(Items, HokmID) > 0 Then
                Dialog.ShowOK("حکم کارمند جاری با موفقیت ثبت شد")
                If HokmID > 0 Then
                    Me.Close()
                Else
                    ResetControls()
                End If

            Else
                Dialog.ShowInfo("متاسفانه اطلاعات ثبت نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("عملیات با خطا مواجه شد", ex.Message)
        End Try
    End Sub
    Private Function GetDtAvamel() As DataTable
        Dim DtReturm As New DataTable
        Dim dr As DataRow
        DtReturm.Columns.Add("ID_Amel")
        DtReturm.Columns.Add("Value")
        For i As Integer = 0 To Me.GrdAvamel.Rows.Count - 1
            If Me.GrdAvamel.Rows(i).Cells("IsSelect").Value = True Then
                dr = DtReturm.NewRow
                dr.Item("ID_Amel") = Me.GrdAvamel.Rows(i).Cells("ID").Value
                dr.Item("Value") = Me.GrdAvamel.Rows(i).Cells("Value").Value
                DtReturm.Rows.Add(dr)
            End If
        Next
        Return DtReturm
    End Function
    Private Sub ResetControls()
        Dim Val As Long = 0
        Me.CmbKargah.SelectedValue = Val
        Me.CmbEstekhdam.SelectedValue = Val
        Me.CmbKhedmat.SelectedValue = Val
        Me.CmbHokm.SelectedValue = Val
        Me.CmbJob.SelectedValue = Val
        Me.TxtPayeh.Text = Val
        Me.UcEndDate.txt = Nothing
        Me.RadPageView1.SelectedPage = Me.RadPageView1.Pages(0)
        Me.TxtPrID.Value = 0
    End Sub
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles BtnSelectJob.Click
        Tools.SelectCmb(Me.CmbJob)
    End Sub
    Private Sub TxtSum_TextChanged(sender As Object, e As EventArgs) Handles TxtSum.TextChanged
        Me.TxtPayehStr.Text = Tools.NumberToString(Me.TxtSum.Text.Trim)
    End Sub
    Private Sub Calculate() Handles TxtPayeh.TextChanged, TxtSaghfFarzand.ValueChanged, TxtZaribEzafehKar.ValueChanged, TxtZaribKasrKar.ValueChanged, TxtChildCount.TextChanged, TxtBon.TextChanged, TxtHaghMaskan.TextChanged
        Dim Base As Int64 = Me.TxtPayeh.Text
        Dim childCount As Integer = 0
        If Pr.ChilCount > Me.TxtSaghfFarzand.Value Then
            childCount = Me.TxtSaghfFarzand.Value
        Else
            childCount = Pr.ChilCount
        End If
        'If Base <= 0 Then
        '    Exit Sub
        'End If
        Me.TxtRoozaneh.Text = Base / 30
        Me.TxtSaati.Text = Base / 220
        Me.TxtMabEzafehKar.Text = Me.TxtSaati.Rls * TxtZaribEzafehKar.Value
        Me.TxtMabKasrKar.Text = Me.TxtSaati.Rls * TxtZaribKasrKar.Value
        Me.TxtOlad.Text = DefaultValues.BasicSalaryPerDayRls * 3 * childCount
        Me.TxtSum.Text = Base + Val(TxtHaghMaskan.Rls) + Val(TxtOlad.Rls) + Val(TxtBon.Rls)
    End Sub
    Private Sub BtnHelp1_Click(sender As Object, e As EventArgs) Handles BtnHelp1.Click
        Tools.ShowHelp(1)
    End Sub
    Private Sub BtnHelp2_Click(sender As Object, e As EventArgs) Handles BtnHelp2.Click
        Tools.ShowHelp(2)
    End Sub
    Private Sub BtnHelp3_Click(sender As Object, e As EventArgs) Handles BtnHelp3.Click
        Tools.ShowHelp(3)
    End Sub
    Private Sub BtnHelp4_Click(sender As Object, e As EventArgs) Handles BtnHelp4.Click
        Tools.ShowHelp(4)
    End Sub
    Private Sub BtnHelp5_Click(sender As Object, e As EventArgs) Handles BtnHelp5.Click
        Tools.ShowHelp(5)
    End Sub
End Class