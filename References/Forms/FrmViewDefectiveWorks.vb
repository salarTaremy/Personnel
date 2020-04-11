Public Class FrmViewDefectiveWorks
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

    Private Sub FrmViewDefectiveWorks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UcDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfMonth)
        UcDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.LastDayOfMonth)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        FillGrid()
    End Sub
    Private Sub FillGrid()
        Try
            Dim Code As String
            If Pr.Exists Then
                Code = Pr.CodePersoneli
            Else
                Code = Nothing
            End If
            Me.Grd.DataSource = pw.GetDefectiveWorks(Me.UcDatePicker1.TxtInt, Me.UcDatePicker2.TxtInt, Code)
            With Me.Grd
                .Columns("Date").HeaderText = "تاریخ"
                .Columns("ID_Pr").HeaderText = "کد کارمند "
                .Columns("Name").HeaderText = "نام و نام خانوادگی"
                .Columns("Date").Width = 110
                .Columns("ID_Pr").Width = 100
                .Columns("Name").Width = 380
            End With
        Catch ex As Exception
            Dialog.ShowErorr("متاسفانه سیستم قادر به خواندن اطلاعات نمیباشد", ex.Message)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            If IsValidData() = False Then
                Exit Sub
            End If
            Dim Frm As New FrmAddWork
            Frm.BtnBrows.Enabled = False
            Frm.TxtPrID.ReadOnly = True
            Frm.TxtPrID.Value = Me.Grd.CurrentRow.Cells("ID_Pr").Value
            Frm.UcDatePicker1.Enabled = False
            Frm.UcDatePicker1.txt = Me.Grd.CurrentRow.Cells("Date").Value
            Frm.ShowDialog()
        Catch ex As Exception
            Dialog.ShowErorr("متاسفانه  در بارگذاری فرم ورود دستی مشکلی پیش آمده", ex.Message)
        End Try
    End Sub

    Private Sub BtnManage_Click(sender As Object, e As EventArgs) Handles BtnManage.Click
        Try
            If IsValidData() = False Then
                Exit Sub
            End If
            Dim Frm As New FrmViewWorkPerDay
            Frm.UcDatePicker1.txt = Me.Grd.CurrentRow.Cells("Date").Value
            Frm.UcDatePicker2.txt = Me.Grd.CurrentRow.Cells("Date").Value
            Frm.TxtPrID.ReadOnly = True
            Frm.TxtPrID.Value = Me.Grd.CurrentRow.Cells("ID_Pr").Value
            Frm.BtnSearch_Click(Nothing, Nothing)
            Frm.ShowDialog()
        Catch ex As Exception
            Dialog.ShowErorr("مشکلی در بارگذاری فرم اصلاحات پیش آمده", ex.Message)
        End Try
    End Sub
    Private Function IsValidData() As Boolean
        If Me.Grd.Rows.Count = 0 Then
            Dialog.ShowInfo("هیچ ایتمی وجود ندارد")
            Return False
        End If
        If IsDBNull(Me.Grd.CurrentRow.Cells("ID_Pr").Value) Then
            Dialog.ShowInfo("لطفا ایتم معتبری را انتخاب کنید")
            Return False
        End If
        If Me.Grd.CurrentRow Is Nothing Then
            Dialog.ShowInfo("شما هیچ ردیفی انتخاب نکرده اید")
            Return False
        End If
        If Me.Grd.CurrentRow.Cells("ID_Pr").Value Is Nothing Then
            Dialog.ShowInfo("لطفا ایتم معتبری را انتخاب کنید")
            Return False
        End If
        Return True
    End Function

End Class