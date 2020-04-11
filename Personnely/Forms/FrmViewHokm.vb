Imports System.Drawing
Imports Common

Public Class FrmViewHokm
    Dim pr As New ClsPersonel
    Dim Hokm As New ClsHokm
    Dim Kargah As New Personnely.ClsPersonBase.Kargah()
    Private Sub BtnBrows_Click(sender As Object, e As EventArgs) Handles BtnBrows.Click
        Dim SelectedPr As ClsPersonel.SelectedPersonnel = pr.SelectPerson()
        Me.TxtPrID.Text = SelectedPr.ID
    End Sub
    Private Sub TxtCodePr_TextChanged(sender As Object, e As EventArgs) Handles TxtPrID.TextChanged
        Dim ID As Integer = 0
        If Me.TxtPrID.Text.Trim <> "" Then
            ID = Val(Me.TxtPrID.Text.Trim)
        End If
        Dim pr As New ClsPersonel(ID)
        TxtPrCode.Text = pr.CodePersoneli
        TxtPrName.Text = pr.Name & " " & pr.Famil
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        FillGrid()
        SetColor()
    End Sub
    Private Sub SetColor()
        For i As Integer = 0 To Me.Grd.Rows.Count - 1
            If CBool(Me.Grd.Rows(i).Cells("Islapse").Value) Then
                Grd.SetRowForeColor(i, Color.Red)
            End If
        Next
    End Sub
    Private Sub FillGrid()
        Try
            Dim CodePersonneli As String = Nothing
            If Not Me.TxtPrCode.Text.Trim = Nothing Then
                CodePersonneli = Me.TxtPrCode.Text.Trim
            End If
            Dim ID_MahaleKhedmat As Short = Me.CmbMahalleKhedmat.SelectedValue
            Dim ID_Company As Byte = Me.CmbCompany.SelectedValue
            Dim ID_Kargah As Long = Me.CmbKargah.SelectedValue

            If Me.ChkActiveHokm.Checked Then
                If ID_Kargah = 0 Then
                    If ID_MahaleKhedmat = 0 Then
                        Grd.DataSource = Hokm.GetAll(CodePersonneli, True, ID_Company)
                    Else
                        Grd.DataSource = Hokm.GetAll(CodePersonneli, True, ID_MahaleKhedmat, ID_Company)
                    End If
                Else
                    If ID_MahaleKhedmat = 0 Then
                        Grd.DataSource = Hokm.GetAll(CodePersonneli, True, ID_Company, ID_Kargah)
                    Else
                        Grd.DataSource = Hokm.GetAll(CodePersonneli, True, ID_MahaleKhedmat, ID_Company, ID_Kargah)
                    End If
                End If
            Else
                If ID_Kargah = 0 Then
                    If ID_MahaleKhedmat = 0 Then
                        Grd.DataSource = Hokm.GetAll(CodePersonneli, ID_Company)
                    Else
                        Grd.DataSource = Hokm.GetAll(CodePersonneli, ID_MahaleKhedmat, ID_Company)
                    End If
                Else
                    If ID_MahaleKhedmat = 0 Then
                        Grd.DataSource = Hokm.GetAll(CodePersonneli, ID_Company, ID_Kargah)
                    Else
                        Grd.DataSource = Hokm.GetAll(CodePersonneli, ID_MahaleKhedmat, ID_Company, ID_Kargah)
                    End If
                End If
            End If
            With Grd
                .Columns("CodePersoneli").HeaderText = "کدپرسنلی"
                .Columns("PrName").HeaderText = "نام"
                .Columns("DateEstekhdam").HeaderText = "استخدام"
                .Columns("DateSodoor").HeaderText = "صدور حکم"
                .Columns("DateStart").HeaderText = "شروع"
                .Columns("DateEnd").HeaderText = "خاتمه"
                .Columns("BasicSalaryPerMonthRls").HeaderText = "حقوق پایه"
                .Columns("BasicSalaryPerDayRls").HeaderText = "دستمزد روزانه"
                .Columns("BasicSalaryPerHoureRls").HeaderText = "دستمزد ساعتی"
                .Columns("MabEzafeKarPerHour").HeaderText = "مبلغ اضافه کار" & vbCrLf & "به ازای هر ساعت"
                .Columns("MabKasrKarPerHour").HeaderText = "مبلغ کسر کار" & vbCrLf & "به ازای هر ساعت"
                .Columns("MabShabKariPerHour").HeaderText = "مبلغ شب کاری" & vbCrLf & "به ازای هر ساعت"
                .Columns("MabTatilKariPerHour").HeaderText = "مبلغ تعطیل کاری" & vbCrLf & "به ازای هر ساعت"
                .Columns("MabOladRls").HeaderText = "حق اولاد"
                .Columns("MabMaskan").HeaderText = "حق مسکن"
                .Columns("MabBoneKargari").HeaderText = "بن کارگری"
                .Columns("HokmType").HeaderText = "نوع حکم"
                .Columns("Kargah").HeaderText = "کارگاه"
                .Columns("Estekhdam").HeaderText = "نوع استخدام"
                .Columns("VaziatKhedmat").HeaderText = "وضعیت خدمت"
                .Columns("JOB").HeaderText = "شغل سازمانی"
                .Columns("ID_Hokm").HeaderText = "شماره حکم"
                .Columns("ShiftName").HeaderText = "شیفت"
                .Columns("Islapse").HeaderText = "باطل"
                .Columns("PayeSanavat").HeaderText = "پایه سنوات"
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                .Columns("BasicSalaryPerMonthRls").TextAlignment = ContentAlignment.MiddleLeft
                .Columns("BasicSalaryPerDayRls").TextAlignment = ContentAlignment.MiddleLeft
                .Columns("BasicSalaryPerHoureRls").TextAlignment = ContentAlignment.MiddleLeft
                .Columns("MabEzafeKarPerHour").TextAlignment = ContentAlignment.MiddleLeft
                .Columns("MabKasrKarPerHour").TextAlignment = ContentAlignment.MiddleLeft
                .Columns("MabShabKariPerHour").TextAlignment = ContentAlignment.MiddleLeft
                .Columns("MabTatilKariPerHour").TextAlignment = ContentAlignment.MiddleLeft
                .Columns("MabOladRls").TextAlignment = ContentAlignment.MiddleLeft
                .Columns("MabMaskan").TextAlignment = ContentAlignment.MiddleLeft
                .Columns("MabBoneKargari").TextAlignment = ContentAlignment.MiddleLeft
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                .Columns("BasicSalaryPerMonthRls").FormatString = "{0:#,###,##0;(#,###,0)}"
                .Columns("BasicSalaryPerDayRls").FormatString = "{0:#,###,##0;(#,###,0)}"
                .Columns("BasicSalaryPerHoureRls").FormatString = "{0:#,###,##0;(#,###,0)}"
                .Columns("MabEzafeKarPerHour").FormatString = "{0:#,###,##0;(#,###,0)}"
                .Columns("MabKasrKarPerHour").FormatString = "{0:#,###,##0;(#,###,0)}"
                .Columns("MabShabKariPerHour").FormatString = "{0:#,###,##0;(#,###,0)}"
                .Columns("MabTatilKariPerHour").FormatString = "{0:#,###,##0;(#,###,0)}"
                .Columns("MabOladRls").FormatString = "{0:#,###,##0;(#,###,0)}"
                .Columns("MabMaskan").FormatString = "{0:#,###,##0;(#,###,0)}"
                .Columns("MabBoneKargari").FormatString = "{0:#,###,##0;(#,###,0)}"
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '                .Columns("Islapse").IsVisible = False
            End With
            Tools.Grd_SetPivotHeaderText(Grd, "Pr.AvmeleHokmi", "Name", "{0:#,###,##0;(#,###,0)}", ContentAlignment.MiddleLeft)
        Catch ex As Exception
            Dialog.ShowErorr("سیستم قادر به خواندن اطلاعات احکام کارمندان نمیباشد", ex.Message)
        End Try
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If Grd.ChildRows.Count <= 0 Then
                Dialog.ShowInfo("حکمی برای حذف وجود ندارد")
                Exit Sub
            End If
            If Grd.CurrentRow Is Nothing Then
                Dialog.ShowInfo("شما هیچ حکمی انتخاب نکرده اید")
                Exit Sub
            End If
            Dim Msg As String = String.Format("آیا برای حذف حکم '{0}' مطمئن هستید؟؟؟", Me.Grd.CurrentRow.Cells("PrName").Value)
            If Dialog.ShowQuestion(Msg) = False Then
                Exit Sub
            End If
            If Hokm.Delete(Me.Grd.CurrentRow.Cells("ID_Hokm").Value) > 0 Then
                Dialog.ShowOK("حکم مورد نظر با موفقیت حذف شد")
                FillGrid()
                SetColor()
            Else
                Dialog.ShowInfo("سیستم قادر به حذف این حکم نمیباشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("عملیات حذف حکم با خطا مواجه شد", ex.Message)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Frm As New FrmHokm
        Frm.ShowDialog()
    End Sub

    Private Sub BtnLapse_Click(sender As Object, e As EventArgs) Handles BtnLapse.Click
        Me.DoLapse(True)
    End Sub

    Private Sub BtnDeLapse_Click(sender As Object, e As EventArgs) Handles BtnDeLapse.Click
        Me.DoLapse(False)
    End Sub
    Private Sub DoLapse(Value As Boolean)
        Try
            Dim Caption As String
            If Value = True Then
                Caption = "ابطال"
            Else
                Caption = "برگشت از ابطال"
            End If
            If Me.Grd.Rows.Count = 0 Then
                Exit Sub
            End If
            If Me.Grd.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim Msg As String = String.Format("آیا برای '{1}' حکم '{0}' مطمئن هستید؟؟؟", Me.Grd.CurrentRow.Cells("PrName").Value, Caption)
            If Dialog.ShowQuestion(Msg) = False Then
                Exit Sub
            End If
            Dim Id As Long = Me.Grd.CurrentRow.Cells("ID_Hokm").Value
            If Hokm.DoLapse(Id, Value) > 0 Then
                Dialog.ShowOK("عملیات با موفقیت انجام شد")
                FillGrid()
                SetColor()
            Else
                Dialog.ShowInfo("متاسفانه عملیات انجام نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("عملیات " & Capture & "  با خطا مواجه شد ", ex.Message)
        End Try
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Grd.ChildRows.Count <= 0 Then
            Dialog.ShowInfo("حکمی برای ویرایش وجود ندارد")
            Exit Sub
        End If
        If Grd.CurrentRow Is Nothing Then
            Dialog.ShowInfo("شما هیچ حکمی انتخاب نکرده اید")
            Exit Sub
        End If
        If CBool(Me.Grd.CurrentRow.Cells("Islapse").Value) Then
            Dialog.ShowInfo("شما مجاز به ویرایش احکام باطل شده نمیباشید لطفا حکم فعالی را برای ویراش انتخاب کنید")
            Exit Sub
        End If
        Dim F As New FrmHokm(Me.Grd.CurrentRow.Cells("ID_Hokm").Value)
        F.ShowDialog()
        FillGrid()
        SetColor()
    End Sub

    Private Sub FrmViewHokm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FillCmb()
        Catch ex As Exception
            Dialog.ShowErorr("بارگزاری فرم با خطا مواجه شد", ex.Message)
        End Try
    End Sub
    Private Sub FillCmb()
        Try
            Dim MK As New ClsPersonBase.MahaleKhedmat()
            Dim Cmp As New ClsGeneral.Company()

            Me.CmbMahalleKhedmat.DisplayMember = "Name"
            Me.CmbMahalleKhedmat.ValueMember = "ID"
            Me.CmbMahalleKhedmat.DataSource = MK.GetAll()

            Me.CmbCompany.DisplayMember = "Name"
            Me.CmbCompany.ValueMember = "ID"
            Me.CmbCompany.DataSource = Cmp.GetAll()

            Me.CmbKargah.DisplayMember = "Name"
            Me.CmbKargah.ValueMember = "ID"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CmbCompany_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles CmbCompany.SelectedIndexChanged
        Me.CmbKargah.DataSource = Kargah.GetAll(CByte(Me.CmbCompany.SelectedValue))
    End Sub
End Class