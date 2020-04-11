Public Class FrmAddSaleMali
    Private SalMali As New Common.SalMali
    Private _IsSaved As Boolean
    Public Property IsSaved() As Boolean
        Get
            Return _IsSaved
        End Get
        Set(ByVal value As Boolean)
            _IsSaved = value
        End Set
    End Property

    Private Sub FrmAddSaleMali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.UcDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfYear)
            Me.UcDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.LastDayOfYear)
            Me.TxtName.IsRequierd = True
        Catch ex As Exception
            Dialog.ShowErorr("خطا در بار گذاری فرم", ex.Message)
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            SalMali.ID = CShort(TxtSal.Text.Trim)
            SalMali.Name = TxtName.Text
            SalMali.From = UcDatePicker1.TxtInt
            SalMali.Too = UcDatePicker2.TxtInt
            If SalMali.Add(SalMali) > 0 Then
                Dialog.ShowOK("سال مالی جدید با موفقیت به سیستم اضافه شد")
                IsSaved = True
                Me.Close()
            Else
                Dialog.ShowInfo("متاسفانه هیچ سال مالی جدیدی به سیستم اضافه نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("خطا در بار گذاری فرم", ex.Message)
        End Try
    End Sub

End Class