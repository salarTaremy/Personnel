Public Class FrmViewWorkPerDay
    Dim Pr As New ClsPersonel
    Dim pw As New ClsPersonnelWork
    Private Sub TxtPrID_ValueChanged(sender As Object, e As EventArgs) Handles TxtPrID.ValueChanged
        Pr = New ClsPersonel(Me.TxtPrID.Value)
        TxtName1.Text = Pr.Name & " " & Pr.Famil
    End Sub
    Private Sub BtnBrows_Click(sender As Object, e As EventArgs) Handles BtnBrows.Click
        Pr = New ClsPersonel()
        Me.TxtPrID.Value = Pr.SelectPersonID()
    End Sub

    Private Sub FrmViewWorkPerDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UcDatePicker1.txt = "" Then
            UcDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfMonth)
        End If
        If UcDatePicker2.txt = "" Then
            UcDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.LastDayOfMonth)
        End If
    End Sub

    Public Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        FillGrid()
        SetColor()
    End Sub
    Private Sub FillGrid()
        Try
            If Pr.Exists = False Then
                Dialog.ShowInfo("لطفا کد پرسنلی معتبری را وارد کنید")
                Exit Sub
            End If
            Me.Grd.DataSource = pw.ViewWorkPerDay(UcDatePicker1.TxtInt, UcDatePicker2.TxtInt, Pr.CodePersoneli.Trim, ChkViewLapse.Checked)
            With Me.Grd
                If .Columns.Contains("DayOfWeek") Then .Columns("DayOfWeek").HeaderText = "شماره روز"
                If .Columns.Contains("DayName") Then .Columns("DayName").HeaderText = "روز"
                If .Columns.Contains("Date") Then .Columns("Date").HeaderText = "تاریخ"
                If .Columns.Contains("ActionType") Then .Columns("ActionType").HeaderText = "ورود/خروج"
                If .Columns.Contains("ActionName") Then .Columns("ActionName").HeaderText = "شرح"
                If .Columns.Contains("time") Then .Columns("time").HeaderText = "ساعت"
                If .Columns.Contains("Action") Then .Columns("Action").HeaderText = "عملیات"
                If .Columns.Contains("HolidayName") Then .Columns("HolidayName").HeaderText = "توضیحات"
                If .Columns.Contains("DayOfWeek") Then .Columns("DayOfWeek").IsVisible = False
                If .Columns.Contains("Action") Then .Columns("Action").IsVisible = False
                If .Columns.Contains("Counter") Then .Columns("Counter").IsVisible = False
                If .Columns.Contains("IsLapse") Then .Columns("IsLapse").IsVisible = False
                If .Columns.Contains("IsManual") Then .Columns("IsManual").IsVisible = False
                If .Columns.Contains("DayName") Then .Columns("DayName").Width = 80
                If .Columns.Contains("Date") Then .Columns("Date").Width = 80
                If .Columns.Contains("ActionType") Then .Columns("ActionType").Width = 80
                If .Columns.Contains("time") Then .Columns("time").Width = 80
                If .Columns.Contains("HolidayName") Then .Columns("HolidayName").Width = 150
                .Columns("DayOfWeek").Width = 238
                .Columns("DayName").Width = 98
                .Columns("Date").Width = 69
                .Columns("ActionType").Width = 59
                .Columns("ActionName").Width = 96
                .Columns("time").Width = 56
                .Columns("Action").Width = 210
                .Columns("HolidayName").Width = 310
                .Columns("Counter").Width = 219
                .Columns("IsLapse").Width = 232
                .Columns("IsManual").Width = 239
            End With
        Catch ex As Exception
            Dialog.ShowErorr("سیستم قادر به خواندن اطلاعات کارکرد کارمندان نمیباشد", ex.Message)
        End Try
    End Sub
    Private Sub SetColor()
        Try
            For i As Integer = 0 To Me.Grd.Rows.Count - 1
                With Me.Grd
                    If Not IsDBNull(.Rows(i).Cells("HolidayName").Value) Then
                        Me.Grd.SetRowBackColor(i, Color.Pink)
                        Me.Grd.SetRowForeColor(i, Color.Red)
                    End If
                    If .Rows(i).Cells("DayOfWeek").Value = 6 Then
                        Me.Grd.SetRowBackColor(i, Color.Pink)
                        Grd.Rows(i).Cells("HolidayName").Value &= " تعطیل رسمی"
                    End If
                    If CBool(.Rows(i).Cells("isLapse").Value) = True Then
                        Me.Grd.SetRowBackColor(i, Color.Red)
                        Grd.Rows(i).Cells("HolidayName").Value &= " باطل شده"
                    End If
                    If CBool(.Rows(i).Cells("IsManual").Value) = True Then
                        Me.Grd.SetRowForeColor(i, Color.Blue)
                        Grd.Rows(i).Cells("HolidayName").Value &= "- دستی  "
                    End If
                End With
            Next
        Catch ex As Exception
            Dialog.ShowErorr("تنظیم رنگ بندی رکورد ها با مشکل مواجه شد", ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If ValidData("حذف") Then
            Delete()
            FillGrid()
        End If
    End Sub
    Private Sub BtnLapse_Click(sender As Object, e As EventArgs) Handles BtnLapse.Click
        If ValidData("ابطال") Then
            DoLapse(True)
            FillGrid()
            SetColor()
        End If
    End Sub
    Private Sub BtnDeLapse_Click(sender As Object, e As EventArgs) Handles BtnDeLapse.Click
        If ValidData("برگشت از ابطال") Then
            DoLapse(False)
            FillGrid()
            SetColor()
        End If
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Dim Frm As New FrmAddWork
            If Me.Grd.Rows.Count > 0 AndAlso Me.Grd.CurrentRow IsNot Nothing Then
                Frm.UcDatePicker1.txt = Me.Grd.CurrentRow.Cells("Date").Value
            End If
            Frm.TxtPrID.Value = Me.TxtPrID.Value
            Frm.ShowDialog()
        Catch ex As Exception
            Dialog.ShowErorr("عملیات بارگذاری فرم ورود اطلاعات با خطا مواجه شد", ex.Message)
        End Try
    End Sub
    Private Sub Delete()
        Try
            If pw.DeletePersonWorkPerDay(Me.Grd.CurrentRow.Cells("Counter").Value) > 0 Then
                Dialog.ShowOK("اطلاعات با موفقیت حذف شدند")
            Else
                Dialog.ShowInfo(" هیچ کارکردی حذف نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("حذف این ردیف از کارکرد با مشکل مواجه شد", ex.Message)
        End Try
    End Sub
    Private Sub DoLapse(Value As Boolean)
        Try
            If pw.UpdateLapseOfPersonWorkPerDay(Me.Grd.CurrentRow.Cells("Counter").Value, Value) > 0 Then
                Dialog.ShowOK("تغییرات با موفقیت انجام شد")
            Else
                Dialog.ShowInfo(" هیچ کارکردی  غیر فعال نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("ابطال این ردیف از کارکرد با مشکل مواجه شد", ex.Message)
        End Try
    End Sub
    Private Function ValidData(ActionName As String) As Boolean
        If Grd.Rows.Count = 0 Or Grd.CurrentRow Is Nothing Then
            Return False
        End If
        If Me.Grd.CurrentRow.Cells("Counter").Value Is DBNull.Value Then
            Dialog.ShowInfo("در این روز کارکردی برای " & ActionName & " وجود ندارد")
            Return False
        End If
        Dim Msg = Nothing
        Msg &= vbCrLf & "آیا برای " & ActionName & " کارکرد جاری مطمئن هستید ؟؟"
        Msg &= vbCrLf & Me.Grd.CurrentRow.Cells("DayName").Value.ToString
        Msg &= vbCrLf & Me.Grd.CurrentRow.Cells("Date").Value.ToString
        Msg &= vbCrLf & Me.Grd.CurrentRow.Cells("ActionType").Value.ToString
        Msg &= vbCrLf & Me.Grd.CurrentRow.Cells("time").Value.ToString
        If Dialog.ShowQuestion(Msg) = False Then
            Return False
        End If
        Return True
    End Function

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim msg As String = "کار کرد پرسنل قابل ویرایش نمیباشد . برای تغییر اصلاحات در کارکرد پرسنل میتوانید از سایر امکانات برنامه مثل : ابطال و برگشت ابطال و یا ثبت کارکرد دستی استفاده نمایید."
        Dialog.ShowInfo(Msg)
    End Sub

    Private Sub BtnDeleteAll_Click(sender As Object, e As EventArgs) Handles BtnDeleteAll.Click
        Try
            Dim Msg As String = String.Format("آیا برای حذف کارکرد  از تاریخ '{0}' تا تاریخ '{1}' اطمینان دارید ؟؟", UcDatePicker1.txt, UcDatePicker2.txt)
            Dim code As String
            If Pr.Exists Then
                code = Pr.CodePersoneli.Trim
                Msg &= vbCrLf & String.Format(" کد پرسنلی : '{0}'", code)
                Msg &= vbCrLf & String.Format(" نام کارمند : '{0}'", Pr.Name & " " & Pr.Famil)
            Else
                code = Nothing
            End If
            If Dialog.ShowQuestion(Msg) = False Then
                Exit Sub
            End If
            Dim RowAffect As Integer = pw.DeletePersonnelWork(UcDatePicker1.TxtInt.ToString, UcDatePicker2.TxtInt.ToString, code, code)
            If RowAffect > 0 Then
                Msg = String.Format("تعداد '{0}' ردیف با موفقیت حذف شد", RowAffect)
                Dialog.ShowOK(Msg)
            Else
                Dialog.ShowInfo("متاسفانه هیچ اطلاعاتی حذف نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("متاسفانه سیستم قادر به حذف اطلاعات از پایگاه داده نمیباشد", ex.Message)
        End Try
    End Sub
End Class