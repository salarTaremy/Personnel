﻿Public Class FrmWeek

    Dim Week As New ClsPersonBase.DayOfWeek

    Private Sub FrmWeek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCmb()
    End Sub
    Private Sub FillCmb()
        With Me.CmbShifts
            .ValueMember = "ID"
            .DisplayMember = "Name"
            .DataSource = Week.GetAllShifts()
        End With
    End Sub

    Private Sub FillGrid(ID_Shift)
        Try
            Me.Grd.DataSource = Week.GetDays(ID_Shift)
            With Me.Grd
                .Columns("Pr_Name").HeaderText = "روز"
                .Columns("Counter").IsVisible = False
                .Columns("ID").IsVisible = False
                .Columns("ID_SHIFT").IsVisible = False
                .Columns("ID_Day").IsVisible = False
                .Columns("InTime").HeaderText = "ورود سازمانی"
                .Columns("OutTime").HeaderText = "خروج سازمانی"
                .Columns("StartLunch").HeaderText = "شروع نهاری"
                .Columns("EndLunch").HeaderText = "خاتمه نهاری"
                .Columns("StartOverTime").HeaderText = "شروع اضافه کاری" & vbCrLf & "آخر وقت"
                .Columns("EndOverTime").HeaderText = "خاتمه اضافه کاری" & vbCrLf & "آخر وقت"
                .Columns("StartOverTimeBeforeTime").HeaderText = "شروع اضافه کار" & vbCrLf & "قبل از وقت"
                .Columns("EndOverTimeBeforeTime").HeaderText = "خاتمه اضافه کار" & vbCrLf & "قبل از وقت"
                .Columns("StartDelay").HeaderText = "تاخیر"
                .Columns("StartNightShift").HeaderText = "شروع شبکاری"
                .Columns("EndNightShift").HeaderText = "خاتمه شبکاری"

                .Columns("Pr_Name").Width = 55
                .Columns("Counter").Width = 50
                .Columns("ID").Width = 27
                .Columns("ID_SHIFT").Width = 57
                .Columns("ID_Day").Width = 46
                .Columns("InTime").Width = 77
                .Columns("OutTime").Width = 87
                .Columns("StartLunch").Width = 84
                .Columns("EndLunch").Width = 80
                .Columns("StartOverTime").Width = 106
                .Columns("EndOverTime").Width = 102
                .Columns("StartOverTimeBeforeTime").Width = 92
                .Columns("EndOverTimeBeforeTime").Width = 87
                .Columns("StartDelay").Width = 43
                .Columns("StartNightShift").Width = 80
                .Columns("EndNightShift").Width = 80
            End With
        Catch ex As Exception
            Dialog.ShowErorr("خطا در خواندن اطلاعات روزهای هفته", ex.Message)
        End Try
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Try
            Dim Dt_Detail As New DataTable
            Dt_Detail.Columns.Add("ID_Day")
            Dt_Detail.Columns.Add("InTime")
            Dt_Detail.Columns.Add("OutTime")
            Dt_Detail.Columns.Add("StartLunch")
            Dt_Detail.Columns.Add("EndLunch")
            Dt_Detail.Columns.Add("StartOverTime")
            Dt_Detail.Columns.Add("EndOverTime")
            Dt_Detail.Columns.Add("StartOverTimeBeforeTime")
            Dt_Detail.Columns.Add("EndOverTimeBeforeTime")
            Dt_Detail.Columns.Add("StartDelay")
            Dt_Detail.Columns.Add("StartNightShift")
            Dt_Detail.Columns.Add("EndNightShift")
            Dim dr_Detail As DataRow
            For i As Integer = 0 To Me.Grd.Rows.Count - 1
                dr_Detail = Dt_Detail.NewRow
                dr_Detail.Item("ID_Day") = Me.Grd.Rows(i).Cells("ID_Day").Value
                dr_Detail.Item("InTime") = Me.Grd.Rows(i).Cells("InTime").Value
                dr_Detail.Item("OutTime") = Me.Grd.Rows(i).Cells("OutTime").Value
                dr_Detail.Item("StartLunch") = Me.Grd.Rows(i).Cells("StartLunch").Value
                dr_Detail.Item("EndLunch") = Me.Grd.Rows(i).Cells("EndLunch").Value
                dr_Detail.Item("StartOverTime") = Me.Grd.Rows(i).Cells("StartOverTime").Value
                dr_Detail.Item("EndOverTime") = Me.Grd.Rows(i).Cells("EndOverTime").Value
                dr_Detail.Item("StartOverTimeBeforeTime") = Me.Grd.Rows(i).Cells("StartOverTimeBeforeTime").Value
                dr_Detail.Item("EndOverTimeBeforeTime") = Me.Grd.Rows(i).Cells("EndOverTimeBeforeTime").Value
                dr_Detail.Item("StartDelay") = Me.Grd.Rows(i).Cells("StartDelay").Value
                dr_Detail.Item("StartNightShift") = Me.Grd.Rows(i).Cells("StartNightShift").Value
                dr_Detail.Item("EndNightShift") = Me.Grd.Rows(i).Cells("EndNightShift").Value
                Dt_Detail.Rows.Add(dr_Detail)
            Next
            If Week.Update(Me.CmbShifts.SelectedValue, Dt_Detail) > 0 Then
                Dialog.ShowOK("اطلاعات با موفقیت ثبت شد")
                FillGrid(Me.CmbShifts.SelectedValue)
            Else
                Dialog.ShowInfo("متاسفانه اطلاعاتی ذخیره نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("عملیات ذخیره با خطا مواجه شد ", ex.Message)
        End Try
    End Sub

    Private Sub Grd_CellEndEdit(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles Grd.CellEndEdit
        With e.Value
            If .ToString.Length = 0 Then
                Exit Sub
            End If
            If .ToString.Length > 5 Or .ToString.Length < 3 Then
                Dialog.ShowInfo(String.Format("'{0}' داده معتبری نمیباشد.لطفا داده معتبری وارد کنید.", e.Value))
                Me.Grd.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing
                Me.Grd.Rows(e.RowIndex).Cells(e.ColumnIndex).BeginEdit()
                Exit Sub
            End If
            If .ToString.IndexOf(":") <> 1 And .ToString.IndexOf(":") <> 2 Then
                Dialog.ShowInfo(String.Format("'{0}' داده معتبری نمیباشد.لطفا داده معتبری وارد کنید.", e.Value))
                Me.Grd.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing
                Me.Grd.Rows(e.RowIndex).Cells(e.ColumnIndex).BeginEdit()
                Exit Sub
            End If
            If .ToString.IndexOf(":") = .ToString.Length - 1 Then
                Dialog.ShowInfo(String.Format("'{0}' داده معتبری نمیباشد.لطفا داده معتبری وارد کنید.", e.Value))
                Me.Grd.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing
                Me.Grd.Rows(e.RowIndex).Cells(e.ColumnIndex).BeginEdit()
                Exit Sub
            End If
        End With
    End Sub

    Private Sub RadDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles CmbShifts.SelectedIndexChanged
        FillGrid(Me.CmbShifts.SelectedValue)
    End Sub
End Class