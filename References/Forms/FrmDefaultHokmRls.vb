Public Class FrmDefaultHokmRls

    Dim DefVal As New ClsHokm.Avamel

    Private Sub FrmDefaultHokmRls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrid()
    End Sub
    Private Sub FillGrid()
        With Me.Grd
            .DataSource = DefVal.GetAllDefaultValues
            .Columns("ID").IsVisible = False
            .Columns("Year").HeaderText = "سال مالی"
            .Columns("BasicSalaryPerMonthRls").HeaderText = "حقوق پایه"
            .Columns("ZaribEzafeKar").HeaderText = "ضریب اضافه کار"
            .Columns("ZaribKasreKar").HeaderText = "ضریب کسر کار"
            .Columns("MaximumChild").HeaderText = "سقف تعداد فرزند "
            .Columns("BonKargari").HeaderText = "بن کارگری"
            .Columns("HaghMaskan").HeaderText = "حق مسکن"
        End With

    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Dialog.ShowQuestion("آیا برای ذخیره تغییرات مطمئن هستید؟؟") Then
            Save()
        End If
    End Sub
    Private Sub Save()
        Try
            Dim Dt_Items As DataTable = GetDtItems()
            If DefVal.UpdateDefaultValues(Dt_Items) > 0 Then
                Dialog.ShowOK("اطلاعات با موفقیت ذخیره  شد")
                FillGrid()
            Else
                Dialog.ShowInfo("متاسفانه عملیات انجام نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("ثبت  مقادیر پیش فرض عوامل با مشکل مواجه شد", ex.Message)
        End Try
    End Sub
    Private Function GetDtItems() As DataTable
        Dim Dt_Temp As New DataTable
        For i As Integer = 0 To Me.Grd.Columns.Count - 1
            Dt_Temp.Columns.Add(Me.Grd.Columns(i).Name.Trim)
        Next
        Dim Dr As DataRow
        For i = 0 To Me.Grd.Rows.Count - 1
            Dr = Dt_Temp.NewRow
            For j As Integer = 0 To Me.Grd.Columns.Count - 1
                Dr.Item(j) = Grd.Rows(i).Cells(j).Value
            Next
            Dt_Temp.Rows.Add(Dr)
        Next
        Return Dt_Temp
    End Function
    Private Sub BtnAdd_Click_1(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Me.Grd.Rows.AddNew()
        Me.Grd.Rows(Me.Grd.Rows.Count - 1).Cells("Year").BeginEdit()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Dim Msg As String = String.Format("آیا برای حذف سال مالی'{0}'مطمئن هستید ؟", Me.Grd.CurrentRow.Cells("Year").Value)
            If Dialog.ShowQuestion(Msg) Then
                Grd.CurrentRow.Delete()
            End If
        Catch ex As Exception
            Dialog.ShowErorr("حذف داده با مشکل مواجه شد", ex.Message)
        End Try
    End Sub
End Class