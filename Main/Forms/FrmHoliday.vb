Public Class FrmHoliday
    Dim Clander As New Common.ClsClander
    Dim _SalMali As Integer
    Private Sub FrmHoliday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrid()
    End Sub
    Private Sub FillGrid()
        Try
            With Me.Grd
                .DataSource = Clander.GetHoliDay(_SalMali)
                .Columns("Date").HeaderText = "تاریخ"
                .Columns("Date").ReadOnly = True
                .Columns("Name").HeaderText = "شرح"
            End With
        Catch ex As Exception
            Dialog.ShowErorr("خواندن اطلاعات تقویم با خطا مواجه شد", ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If Me.Grd.Rows.Count = 0 Then
                Exit Sub
            End If
            If Me.Grd.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim msg As String = "برای حذف این روز مطمئن هستید؟" & vbCrLf
            msg &= Me.Grd.CurrentRow.Cells("Date").Value.ToString & vbCrLf
            msg &= Me.Grd.CurrentRow.Cells("Name").Value.ToString & vbCrLf
            If Dialog.ShowQuestion(msg) = False Then
                Exit Sub
            End If
            If Clander.DeleteHoliDay(Me.Grd.CurrentRow.Cells("Date").Value.ToString.Trim) > 0 Then
                Dialog.ShowOK("اطلاعا با موفقیت به حذف شد")
                FillGrid()
            Else
                Dialog.ShowInfo("هیج اطلاعاتی حذف نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("خطایی در حذف اطلاعات تقویم بوجود آمد", ex.Message)
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            If Dialog.ShowQuestion("برای ذخیره مطمئن هستید ؟؟") = False Then
                Exit Sub
            End If
            If Clander.UpdateHoliDay(_SalMali, Me.Grd.DataSource) > 0 Then
                Dialog.ShowOK("اطلاعا با موفقیت به روز رسانی شد")
                Me.Close()
            Else
                Dialog.ShowInfo("متاسفانه اطلاعاتی ثبت نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("خطا در ذخیره اطلاعات", ex.Message)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            If Mid(Me.UcDate.txt, 1, 4) <> _SalMali Then
                Dialog.ShowInfo("تاریخ باید در محدوده سال مالی جاری باشد")
                Exit Sub
            End If
            If Me.TxtDetail.Text = "" Then
                Dialog.ShowInfo("شرح نمیتواند خالی باشد")
                Exit Sub
            End If
            Me.Grd.Rows.AddNew()
            Me.Grd.Rows(Me.Grd.Rows.Count - 1).Cells("date").Value = UcDate.txt.Trim
            Me.Grd.Rows(Me.Grd.Rows.Count - 1).Cells("Name").Value = TxtDetail.Text.Trim
            Me.TxtDetail.Text = Nothing
        Catch ex As Exception
            Dialog.ShowErorr("افزودن اطلاعات جدید با خطا مواجه شد", ex.Message)
        End Try
    End Sub

    Public Sub New(SalMali)

        ' This call is required by the designer.
        InitializeComponent()
        Me._SalMali = SalMali
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class