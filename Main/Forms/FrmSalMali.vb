Public Class FrmSalMali
    Dim SalMali As New Common.SalMali
    Private Sub FrmSalMali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FillGrid()
        Catch ex As Exception
            Dialog.ShowErorr("خطا در بارگذاری فرم", ex.Message)
        End Try

    End Sub

    Private Sub FillGrid()
        Try

            Me.Grd.DataSource = SalMali.GetSalMali()
            With Me.Grd
                .Columns("ID").HeaderText = "سال"
                .Columns("NAME").HeaderText = "شرح"
                .Columns("From").HeaderText = "از "
                .Columns("To").HeaderText = "تا"
                .Columns("FromDate").HeaderText = "تاریخ شروع"
                .Columns("ToDate").HeaderText = "تاریخ خاتمه"
                .Columns("From").IsVisible = False
                .Columns("To").IsVisible = False
                .Columns("ID").Width = 70
                .Columns("NAME").Width = 220
                .Columns("From").Width = 95
                .Columns("To").Width = 95
                .Columns("FromDate").Width = 80
                .Columns("ToDate").Width = 80
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If Me.Grd.SelectedRows.Count = 0 Then
                Dialog.ShowInfo("لطفا یکی از موارد  را انتخاب کنید")
                Exit Sub
            End If
            Dim Msg As String = String.Format("آیا برای حذف سال مالی {0} مطمئن هستید ؟!؟", Me.Grd.CurrentRow.Cells("ID").Value.ToString)
            If Dialog.ShowQuestion(Msg) = False Then
                Exit Sub
            End If
            If SalMali.Delete(Me.Grd.CurrentRow.Cells("ID").Value) > 0 Then
                Dialog.ShowOK("سال مالی با موفقیت حذف شد")
                FillGrid()
            Else
                Dialog.ShowInfo("متاسفانه عملیات حذف سال مالی انجام نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("خطا در حذف سال مالی", ex.Message)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Dim f As New FrmAddSaleMali
            f.ShowDialog()
            If f.IsSaved Then
                FillGrid()
            End If
        Catch ex As Exception
            Dialog.ShowErorr("خطا در بارگذاری فرم سال مالی", ex.Message)
        End Try
    End Sub
End Class